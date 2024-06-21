using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.Events.GetEventResponse;

namespace UITEventAPI.Application.Features.Events;

public class GetEventController : ApiControllerBase
{
    [HttpGet("events/{id}")]
    public async Task<IActionResult> GetEvent(int id)
    {
        var result = await Sender.Send(new GetEventQuery(id));
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
    bool IsPublished,
    string FormUrl,
    string Type,
    int TrainingPoint,
    int MaxAttendees,
    int UniversityUnitId,
    bool IsDeleted,
    DateTimeOffset DeletedWhen,
    IEnumerable<EventImageDto> Images,
    int TotalRegistration
)
{
    public sealed record EventImageDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = ImageConstants.DefaultImageUrl;
    }
}


public record GetEventQuery(int EventId) : IRequest<Result<GetEventResponse>>;

public class GetEventQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetEventQuery, Result<GetEventResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<Result<GetEventResponse>> Handle(GetEventQuery request, CancellationToken cancellationToken)
    {
        var eventObj = await _dbContext.Events
            .Where(e => e.Id == request.EventId)
            .Include(e => e.Images)
            .Include(e => e.Registrations)
            .FirstOrDefaultAsync(cancellationToken);

        if (eventObj is null)
        {
            return Result.Failure<GetEventResponse>(EventErrors.NotFound);
        }

        var eventImages = eventObj.Images.Select(i => i.Adapt<EventImageDto>());
        var totalRegistration = eventObj.Registrations.Count;

        var response = eventObj.Adapt<GetEventResponse>() with
        {
            Images = eventImages,
            TotalRegistration = totalRegistration
        };

        return response;
    }
}