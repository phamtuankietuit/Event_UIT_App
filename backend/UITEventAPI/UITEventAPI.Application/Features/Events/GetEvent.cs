using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.UniversityUnits;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.Events.GetEventResponse;

namespace UITEventAPI.Application.Features.Events;

public class GetEventController : ApiControllerBase
{
    [Authorize]
    [HttpGet("events/{id}")]
    public async Task<IActionResult> GetEvent(int id)
    {
        var userId = User.GetUserId();

        var query = new GetEventQuery(id, int.Parse(userId!));
        var result = await Sender.Send(query);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetEventResponse(
    int Id,
    string Title,
    string Description,
    string Location,
    DateTime StartDate,
    DateTime EndDate,
    DateTime? PublishedDate,
    bool IsPublished,
    string FormUrl,
    string Type,
    int TrainingPoint,
    string? QRImageUrl,
    int MaxAttendees,
    IEnumerable<EventImageDto> Images,
    int TotalRegistration,
    UniversityUnitDto UniversityUnit,
    bool? IsThisStudentRegistered
)
{
    public bool? IsThisStudentRegistered { get; set; } = IsThisStudentRegistered;

    public sealed record EventImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = ImageConstants.DefaultImageUrl;
    }

    public sealed record UniversityUnitDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AvatarUrl { get; set; } = ImageConstants.DefaultAvatarUrl;
        public string FacebookUrl { get; set; } = string.Empty;
    }
}


public record GetEventQuery(int EventId, int UserId) : IRequest<Result<GetEventResponse>>;

public class GetEventQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetEventQuery, Result<GetEventResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    static GetEventQueryHandler()
    {
        TypeAdapterConfig.GlobalSettings.Default.MapToConstructor(true);

        TypeAdapterConfig<UniversityUnit, UniversityUnitDto>
            .NewConfig()
            .Map(dest => dest.AvatarUrl, u => u.User.AvatarUrl);

        TypeAdapterConfig<Event, GetEventResponse>
            .NewConfig()
            .Map(dest => dest.Type, e => e.Type.ToString())
            .Map(dest => dest.Images, e => e.Images.Select(i => i.Adapt<EventImageDto>()))
            .Map(dest => dest.TotalRegistration, e => e.Registrations.Count)
            .Map(dest => dest.UniversityUnit, e => e.UniversityUnit.Adapt<UniversityUnitDto>());
    }

    public async Task<Result<GetEventResponse>> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        var eventId = request.EventId;

        var response = await _dbContext.Events
            .Where(e => e.Id == eventId)
            .Include(e => e.Images)
            .Include(e => e.Registrations)
            .Include(e => e.UniversityUnit)
                .ThenInclude(e => e.User)
            .Select(e => new GetEventResponse(
                e.Id,
                e.Title,
                e.Description,
                e.Location,
                e.StartDate,
                e.EndDate,
                e.PublishedDate,
                e.IsPublished,
                e.FormUrl,
                e.Type.ToString(),
                e.TrainingPoint,
                e.QRImageUrl,
                e.MaxAttendees,
                e.Images.Select(i => i.Adapt<EventImageDto>()),
                e.Registrations.Count,
                e.UniversityUnit.Adapt<UniversityUnitDto>(),
                null
            ))
            .FirstOrDefaultAsync(cancellationToken);

        if (response is null)
        {
            return Result.Failure<GetEventResponse>(EventErrors.NotFound);
        }
        
        var student = await _dbContext.Students
            .Include(s => s.RegisteredEvents)
            .FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

        if (student is not null)
        {
            response.IsThisStudentRegistered = student.RegisteredEvents.Any(e => e.EventId == eventId);
        }
       
        return response;
    }
}