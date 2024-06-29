using Bogus.DataSets;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;
using static System.Net.Mime.MediaTypeNames;
using static UITEventAPI.Application.Features.Events.UpdateEventCommand;

namespace UITEventAPI.Application.Features.Events;

public class UpdateEventController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.UnitAdmin)]
    [HttpPut("events/{id}")]
    public async Task<IActionResult> UpdateEvent(int id, [FromBody] UpdateEventCommand command)
    {
        if (id != command.Id)
        {
            return BadRequest();
        }

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record UpdateEventResponse(
    int Id,
    string Title,
    string Description,
    string Location,
    DateTime StartDate,
    DateTime EndDate,
    bool IsPublished,
    string FormUrl,
    string Type,
    int TrainingPoint,
    int MaxAttendees,
    int UniversityUnitId,
    string? QRImageUrl,
    IEnumerable<EventImageDto> Images
);

public record UpdateEventCommand(
    int Id,
    string Title,
    string Description,
    string Location,
    DateTime StartDate,
    DateTime EndDate,
    bool IsPublished,
    string FormUrl,
    string Type,
    int TrainingPoint,
    int MaxAttendees,
    int UniversityUnitId,
    string? QRImageUrl,
    IEnumerable<EventImageDto> Images,
    IEnumerable<string>? ImagesBase64 = null
) : IRequest<Result<UpdateEventResponse>>
{
    public sealed record EventImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = ImageConstants.DefaultImageUrl;
    }
}

public class UpdateEventValidator : AbstractValidator<UpdateEventCommand>
{
    public UpdateEventValidator()
    {
        RuleFor(e => e.Title).NotEmpty().MaximumLength(400);
        RuleFor(e => e.Description).NotEmpty();
        RuleFor(e => e.Location).NotEmpty();
        RuleFor(e => e.StartDate).NotEmpty();
        RuleFor(e => e.EndDate).NotEmpty().GreaterThan(e => e.StartDate);
        RuleFor(e => e.Type).IsEnumName(typeof(EventType));
        RuleFor(e => e.TrainingPoint).GreaterThanOrEqualTo(0);
        RuleFor(e => e.MaxAttendees).GreaterThan(0);
        RuleFor(e => e.UniversityUnitId).GreaterThan(0);
    }
}

public class UpdateEventCommandHandler(
    ApplicationDbContext dbContext,
    ILogger<UpdateEventCommandHandler> logger,
    IDateTimeService dateTimeService,
    IBlobService blobService,
    INotificationService notificationService
) : IRequestHandler<UpdateEventCommand, Result<UpdateEventResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly ILogger<UpdateEventCommandHandler> _logger = logger;
    private readonly IDateTimeService _dateTimeService = dateTimeService;
    private readonly IBlobService _blobService = blobService;
    private readonly INotificationService _notificationService = notificationService;

    public async Task<Result<UpdateEventResponse>> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

        try
        {
            var eventEntity = await _dbContext.Events
                .Where(e => e.Id == request.Id)
                .Include(e => e.Images)
                .Include(e => e.Registrations)
                .Include(e => e.UniversityUnit)
                .FirstOrDefaultAsync(cancellationToken);

            if (eventEntity == null)
            {
                return Result.Failure<UpdateEventResponse>(EventErrors.NotFound);
            }

            var updateResult = UpdateEvent(request, eventEntity);
            if (updateResult.IsFailure)
            {
                await transaction.RollbackAsync(cancellationToken);
                return Result.Failure<UpdateEventResponse>(updateResult.Error);
            }
            
            // Delete the missing images, collected from the request, add new images to dbContext.EventImages
            var imageIds = request.Images.Select(i => i.Id);
            var imagesToDelete = eventEntity.Images.Where(i => !imageIds.Contains(i.Id)).ToList();
            
            var uploadImageResult = await UploadImageToStorageAsync(request.ImagesBase64, eventEntity.Id);
            if(uploadImageResult.IsFailure)
            {
                await transaction.RollbackAsync(cancellationToken);
                return Result.Failure<UpdateEventResponse>(uploadImageResult.Error);
            }

            await RemoveImageFromStorage(imagesToDelete);

            _dbContext.EventImages.RemoveRange(imagesToDelete);
            await _dbContext.EventImages.AddRangeAsync(uploadImageResult.Value.AsEnumerable(), cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            await transaction.CommitAsync(cancellationToken);

            // Load the images for updated entity
            _dbContext.Entry(eventEntity).Collection(e => e.Images).Load();

            var response = eventEntity.Adapt<UpdateEventResponse>() with
            {
                Images = eventEntity.Images.Select(i => i.Adapt<EventImageDto>())
            };

            return response;
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken);
            _logger.LogError(ex, "Update event failed, error message: {Error}", ex.Message);
            return Result.Failure<UpdateEventResponse>(EventErrors.UpdateFailed);
        }
    }

    private async Task RemoveImageFromStorage(List<EventImage> imagesToDelete)
    {
        foreach (var image in imagesToDelete)
        {
            var fileName = image.ImageUrl.Split('/').Last();
            if (fileName.Contains('?'))
                continue;
            await _blobService.DeleteFileAsync("event-images", fileName);
        }
    }

    private async Task<Result<EventImage[]>> UploadImageToStorageAsync(IEnumerable<string>? imagesBase64, int eventId)
    {
        ICollection<EventImage> images = [];

        if (imagesBase64 == null)
        {
            return Result.Success(images.ToArray());
        }

        foreach (var imageBase64 in imagesBase64)
        {
            // format now as YearMonthDayHourMinuteSecond
            var fileName = $"{eventId}-{_dateTimeService.NowInFileName}";

            try
            {
                var imageUrl = await _blobService.UploadImageAsync("event-images", fileName, imageBase64);
                images.Add(new() { EventId = eventId, ImageUrl = imageUrl.AbsoluteUri });
            }
            catch (FormatException ex)
            {
                _logger.LogError(ex, "Invalid image base64 format");
                return Result.Failure<EventImage[]>(EventErrors.InvalidImageBase64Format);
            }
        }

        return Result.Success(images.ToArray());
    }

    private Result UpdateEvent(UpdateEventCommand request, Event eventEntity)
    {
        eventEntity.Title = request.Title;
        eventEntity.Description = request.Description;
        eventEntity.Location = request.Location;

        eventEntity.StartDate = request.StartDate;
        eventEntity.EndDate = request.EndDate;


        eventEntity.FormUrl = request.FormUrl;
        eventEntity.Type = Enum.Parse<EventType>(request.Type);

        if (eventEntity.QRImageUrl != request.QRImageUrl || 
            request.UniversityUnitId != eventEntity.UniversityUnitId
        )
        {
            return Result.Failure(EventErrors.NotChangeable(nameof(Event.QRImageUrl)));
        }

        // todo: add a notification that this event has updated its training point
        eventEntity.TrainingPoint = request.TrainingPoint;

        // Update MaxAttendees
        var currentAttendees = eventEntity.Registrations.Count;
        if (request.MaxAttendees < currentAttendees)
        {
            return Result.Failure(EventErrors.MaxAttendeesExceedRegisteredCount);
        }
        eventEntity.MaxAttendees = request.MaxAttendees;

        // Update IsPublished and PublishedDate
        if (request.IsPublished)
        {
            eventEntity.PublishedDate = _dateTimeService.Now;

            _notificationService.SendNotificationAsync(
                eventEntity.UniversityUnitId.ToString(),
                "Sự kiện mới vừa được đăng",
                $"Sự kiện {eventEntity.Title} vừa được đăng bởi {eventEntity.UniversityUnit.Name}"
            );
        }
        eventEntity.IsPublished = request.IsPublished;

        return Result.Success();
    }
}