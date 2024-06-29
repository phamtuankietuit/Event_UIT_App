using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.UniversityUnits;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.UniversityUnits.GetUniversityUnitResponse;

namespace UITEventAPI.Application.Features.UniversityUnits;

public class GetUniversityUnitController : ApiControllerBase
{
    [HttpGet("university-units/{universityUnitId}/details")]
    public async Task<IActionResult> GetUniversityUnit([FromRoute] int universityUnitId, [FromQuery] GetUniversityUnitRequest request)
    {
        var query = request.Adapt<GetUniversityUnitQuery>() with
        {
            UniversityUnitId = universityUnitId
        };

        var result = await Sender.Send(query);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetUniversityUnitRequest(int? StudentId);

public record GetUniversityUnitResponse(
    int Id,
    string Name,
    string Description,
    string FacebookUrl,
    string AvatarUrl,
    int TotalFollowers,
    IEnumerable<EventDto> HostedEvent
)
{
    public bool? IsThisStudentFollowed { get; set; } = null;

    public sealed record EventDto(
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
        int TotalRegistration
        );

    public sealed record EventImageDto(int Id, string ImageUrl);
}

public record GetUniversityUnitQuery(int UniversityUnitId, int? StudentId) : IRequest<Result<GetUniversityUnitResponse>>;

public class GetUniversityUnitQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetUniversityUnitQuery, Result<GetUniversityUnitResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    
    static GetUniversityUnitQueryHandler()
    {
        TypeAdapterConfig<Event, EventDto>.NewConfig()
            .Map(dest => dest.Images, src => src.Images.Select(i => i.Adapt<EventImageDto>()))
            .Map(dest => dest.TotalRegistration, src => src.Registrations.Count);

        TypeAdapterConfig.GlobalSettings.Default.MapToConstructor(true);
        TypeAdapterConfig<UniversityUnit, GetUniversityUnitResponse>.NewConfig()
            .Map(dest => dest.AvatarUrl, src => src.User.AvatarUrl)
            .Map(dest => dest.TotalFollowers, src => src.FollowedStudents.Count)
            .Map(dest => dest.HostedEvent, src => src.HostedEvents.Select(e => e.Adapt<EventDto>()));
    }

    public async Task<Result<GetUniversityUnitResponse>> Handle(GetUniversityUnitQuery request, CancellationToken cancellationToken)
    {
        var unitId = request.UniversityUnitId;
        var response = await _dbContext.UniversityUnits
            .Where(x => x.Id == request.UniversityUnitId)
            .Include(u => u.FollowedStudents)
            .Include(u => u.User)
            .Include(u => u.HostedEvents)
                .ThenInclude(u => u.Registrations)
            .Include(u => u.HostedEvents)
                .ThenInclude(u => u.Images)
            .AsSplitQuery()
            .Select(u => u.Adapt<GetUniversityUnitResponse>())
            .FirstOrDefaultAsync(cancellationToken);

        if (response == null)
            return Result.Failure<GetUniversityUnitResponse>(UniversityUnitErrors.NotFound);

        var studentId = request.StudentId;
        if (studentId.HasValue)
        {
            var unitFollows = await _dbContext.UnitFollows
                .FirstOrDefaultAsync(uf => uf.StudentId == studentId && uf.UniversityUnitId == unitId && uf.IsFollowed, cancellationToken);

            response.IsThisStudentFollowed = unitFollows is not null;
        }

        return response;
    }
}