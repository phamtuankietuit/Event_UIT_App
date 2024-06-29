using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.Students.GetRegisteredEventsResponse;

namespace UITEventAPI.Application.Features.Students;

public class GetRegisteredEventsController : ApiControllerBase
{
    static GetRegisteredEventsController()
    {
        TypeAdapterConfig.GlobalSettings.Default.MapToConstructor(true);
    }

    [Authorize(Roles = UserRoleConstants.Student)]
    [HttpGet("students/me/events")]
    public async Task<IActionResult> GetRegisteredEvents([FromQuery] GetRegisteredEventsRequest request)
    {
        var userId = User.GetUserId();

        var query = request.Adapt<GetRegisteredEventsQuery>() with
        {
            UserId = int.Parse(userId!)
        };

        var result = await Sender.Send(query);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetRegisteredEventsRequest : IRequest<Result<GetRegisteredEventsResponse>>
{
    public SortingOptions SortOptions { get; init; }
    public PagingOptions PagingOptions { get; init; }


    public GetRegisteredEventsRequest(
        [FromQuery(Name = "")] SortingOptions? SortOptions,
        [FromQuery(Name = "")] PagingOptions? PagingOptions
    )
    {
        this.SortOptions = SortOptions ?? new();
        this.PagingOptions = PagingOptions ?? new();
    }
}

public record GetRegisteredEventsResponse (PaginatedList<EventDto> Events)
{
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
        IEnumerable<EventImageDto> Images,
        UniversityUnitDto UniversityUnit
        );

    public sealed record EventImageDto(int Id, string ImageUrl);
    public sealed record UniversityUnitDto(int Id, string Name, string Description, string AvatarUrl, string FacebookUrl);
}

public record GetRegisteredEventsQuery : IRequest<Result<GetRegisteredEventsResponse>>
{
    public int UserId { get; init; }
    public SortingOptions SortOptions { get; init; }
    public PagingOptions PagingOptions { get; init; }
    

    public GetRegisteredEventsQuery(
        [FromQuery(Name = "")] SortingOptions? SortOptions,
        [FromQuery(Name = "")] PagingOptions? PagingOptions
    )
    {
        this.SortOptions = SortOptions ?? new();
        this.PagingOptions = PagingOptions ?? new();
    }
}

public class GetRegisteredEventsHandler(ApplicationDbContext context) : IRequestHandler<GetRegisteredEventsQuery, Result<GetRegisteredEventsResponse>>
{
    private readonly ApplicationDbContext _context = context;

    public async Task<Result<GetRegisteredEventsResponse>> Handle(GetRegisteredEventsQuery query, CancellationToken cancellationToken)
    {
        var student = await _context.Students
            .FirstOrDefaultAsync(s => s.UserId == query.UserId, cancellationToken);

        if (student == null)
        {
            return Result.Failure<GetRegisteredEventsResponse>(UserErrors.NotFound);
        }

        var events = _context.EventRegistrations
            .Include(e => e.Event)
                .ThenInclude(e => e.Images)
            .Where(e => e.StudentId == student.Id)
            .OrderByDescending(e => e.RegisterDate)
            .Select(re => re.Event)
            .Select(e => new EventDto(
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
                e.Images.Select(i => new EventImageDto(i.Id, i.ImageUrl)),
                new UniversityUnitDto(
                    e.UniversityUnit.Id,
                    e.UniversityUnit.Name,
                    e.UniversityUnit.Description,
                    e.UniversityUnit.User.AvatarUrl,
                    e.UniversityUnit.FacebookUrl
                )
            ));

        var result = await PaginatedList<EventDto>.CreateAsync(events, query.PagingOptions.PageNumber, query.PagingOptions.PageSize);

        return Result.Success(new GetRegisteredEventsResponse(result));
    }
}