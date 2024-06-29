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
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.Events.CreateEventResponse;

namespace UITEventAPI.Application.Features.Events;

public class CreateEventController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.UnitAdmin)]
    [HttpPost("events")]
    public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest request)
    {
        var userId = User.GetUserId();

        var command = request.Adapt<CreateEventCommand>() with
        {
            UserId = int.Parse(userId!)
        };

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record CreateEventRequest(
    string Title,
    string Description,
    string Location,
    DateTime StartDate,
    DateTime EndDate,
    bool IsPublished,
    string FormUrl,
    string Type,
    int MaxAttendees,
    int UniversityUnitId,
    IEnumerable<string> ImagesBase64
);

public record CreateEventResponse(
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
    IEnumerable<EventImageDto> Images
)
{
    public sealed record EventImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = ImageConstants.DefaultImageUrl;
    }
}

public record CreateEventCommand(
    int Id,
    string Title,
    string Description,
    string Location,
    DateTime StartDate,
    DateTime EndDate,
    bool IsPublished,
    string FormUrl,
    string Type,
    int MaxAttendees,
    int UniversityUnitId,
    IEnumerable<string> ImagesBase64,
    int UserId
) : IRequest<Result<CreateEventResponse>>;

public class CreateEventValidator : AbstractValidator<CreateEventCommand>
{
    public CreateEventValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.Description).NotEmpty();
        RuleFor(x => x.Location).NotEmpty();
        RuleFor(x => x.StartDate).NotEmpty();
        RuleFor(x => x.EndDate).NotEmpty().GreaterThan(x => x.StartDate);
        RuleFor(x => x.FormUrl).NotEmpty();
        RuleFor(x => x.Type).IsEnumName(typeof(EventType));
        RuleFor(x => x.MaxAttendees).GreaterThan(0);
        RuleFor(x => x.UniversityUnitId).GreaterThan(0);
    }
}

public class CreateEventCommandHandler(
    ILogger<CreateEventCommandHandler> logger,
    ApplicationDbContext dbContext,
    IBlobService blobService,
    IDateTimeService dateTimeService,
    INotificationService notificationService
) : IRequestHandler<CreateEventCommand, Result<CreateEventResponse>>
{
    private readonly ILogger<CreateEventCommandHandler> _logger = logger;
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IDateTimeService _dateTimeService = dateTimeService;
    private readonly INotificationService _notificationService = notificationService;

    public async Task<Result<CreateEventResponse>> Handle(CreateEventCommand request, CancellationToken cancellationToken)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

        try
        {
            var unit = await _dbContext.UniversityUnits.FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

            if (unit == null)
            {
                return Result.Failure<CreateEventResponse>(EventErrors.Unauthorized);
            }

            var eventObj = new Event
            {
                Title = request.Title,
                Description = request.Description,
                Location = request.Location,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                IsPublished = request.IsPublished,
                FormUrl = request.FormUrl,
                Type = Enum.Parse<EventType>(request.Type),
                MaxAttendees = request.MaxAttendees,
                UniversityUnitId = unit.Id
            };

            await _dbContext.Events.AddAsync(eventObj, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            var imageDtosResult = await CreateEventImagesAsync(request.ImagesBase64, eventObj.Id);
            if (imageDtosResult.IsFailure)
            {
                return Result.Failure<CreateEventResponse>(imageDtosResult.Error);
            }
            
            await transaction.CommitAsync(cancellationToken);

            var response = eventObj.Adapt<CreateEventResponse>() with
            {
                Images = imageDtosResult.Value
            };

            // after creating event, send notification to subscribed users
            if (eventObj.IsPublished)
            {
                var title = "Sự kiện mới vừa được đăng";
                var body = $"Sự kiện {eventObj.Title} vừa được đăng bởi {unit.Name}";
                await _notificationService.SendNotificationAsync(unit.Id.ToString(), title, body);
            }

            return response;
        }
        catch (Exception ex)
        {
            await transaction.RollbackAsync(cancellationToken);
            _logger.LogError(ex, "Create event failed");
            return Result.Failure<CreateEventResponse>(EventErrors.CreateFailed);
        }
    }

    private async Task<Result<IEnumerable<EventImageDto>>> CreateEventImagesAsync(IEnumerable<string> imagesBase64, int eventId)
    {
        // upload base64 images to blob storage
        ICollection<EventImage> images = [];

        foreach (var imageBase64 in imagesBase64)
        {
            // format now as YearMonthDayHourMinuteSecond
            var fileName = $"{eventId}-{_dateTimeService.NowInFileName}";

            try
            {
                var imageUrl = await blobService.UploadImageAsync("event-images", fileName, imageBase64);
                images.Add(new() { EventId = eventId, ImageUrl = imageUrl.AbsoluteUri });
            }
            catch(FormatException ex)
            {
                _logger.LogError(ex, "Invalid image base64 format");
                return Result.Failure<IEnumerable<EventImageDto>>(EventErrors.InvalidImageBase64Format);
            }
        }

        await _dbContext.AddRangeAsync(images);
        await _dbContext.SaveChangesAsync();

        var imageDtos = images.Select(i => new EventImageDto { Id = i.Id, ImageUrl = i.ImageUrl });

        return Result.Success(imageDtos);
    }
}






