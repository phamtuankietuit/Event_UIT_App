using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
using FluentValidation;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Common.Utils;
using UITEventAPI.Application.Common.Validators;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.UniversityUnits;
using UITEventAPI.Application.Extensions;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.Events.GetEventsResponse;

namespace UITEventAPI.Application.Features.Events;

public class GetEventsController : ApiControllerBase
{
    static GetEventsController()
    {
        TypeAdapterConfig.GlobalSettings.Default.MapToConstructor(true);
    }

    [Authorize]
    [HttpGet("events")]
    public async Task<IActionResult> GetEvents([FromQuery] GetEventsRequest request)
    {
        var userId = User.GetUserId();

        var query = request.Adapt<GetEventsQuery>() with
        {
            UserId = int.Parse(userId!)
        };

        var result = await Sender.Send(query);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetEventsRequest
{
    public SortingOptions SortOptions { get; init; }
    public PagingOptions PagingOptions { get; init; }
    public GetEventsFilter Filter { get; init; }

    public GetEventsRequest(
        [FromQuery(Name = "")] GetEventsFilter? Filter,
        [FromQuery(Name = "")] SortingOptions? SortOptions,
        [FromQuery(Name = "")] PagingOptions? PagingOptions
    )
    {
        this.Filter = Filter ?? new();
        this.SortOptions = SortOptions ?? new();
        this.PagingOptions = PagingOptions ?? new();
    }
}

public record GetEventsResponse(PaginatedList<EventDto> Events)
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
        string? QRImageUrl,
        int MaxAttendees,
        IEnumerable<EventImageDto> Images,
        int TotalRegistration,
        UniversityUnitDto UniversityUnit,
        bool? IsThisStudentRegistered
        )
    {
        public bool? IsThisStudentRegistered { get; set; } = IsThisStudentRegistered;
    }

    public sealed record EventImageDto(int Id, string ImageUrl);
    public sealed record UniversityUnitDto(int Id, string Name, string Description, string AvatarUrl, string FacebookUrl);
}

public record GetEventsFilter(
    DateRange? StartDateRange = null,
    DateRange? EndDateRange = null,
    string? Type = null,
    bool? IsPublished = null,
    bool? IsGetFollowing = false,
    string? SearchTerm = null
);

public record GetEventsQuery : IRequest<Result<GetEventsResponse>>
{
    public int UserId { get; init; }
    public SortingOptions SortOptions { get; init; }
    public PagingOptions PagingOptions { get; init; }
    public GetEventsFilter Filter { get; init; }

    public GetEventsQuery(
        [FromQuery(Name = "")] GetEventsFilter? Filter,
        [FromQuery(Name = "")] SortingOptions? SortOptions,
        [FromQuery(Name = "")] PagingOptions? PagingOptions
    )
    {
        this.Filter = Filter ?? new();
        this.SortOptions = SortOptions ?? new();
        this.PagingOptions = PagingOptions ?? new();
    }
}

public class GetEventsQueryValidator : AbstractValidator<GetEventsQuery>
{
    private readonly IEnumerable<string> SortableProperty =
    [
        nameof(Event.Id),
        nameof(Event.Type),
        nameof(Event.StartDate),
        nameof(Event.EndDate),
        nameof(Event.CreatedDate)
    ];

    public GetEventsQueryValidator()
    {
        RuleFor(x => x.Filter.Type)
            .IsEnumName(typeof(EventType), caseSensitive: false)
            .WithMessage(string.Format(ValidationMessages.InvalidEnumValue, nameof(GetEventsFilter.Type), string.Join(", ", Enum.GetValues<EventType>())));

        RuleFor(x => x.Filter.StartDateRange)
            .SetValidator(new DateRangeValidator())
            .When(x => x.Filter.StartDateRange is not null);

        RuleFor(x => x.Filter.EndDateRange)
            .SetValidator(new DateRangeValidator())
            .When(x => x.Filter.EndDateRange is not null);

        RuleFor(x => x.SortOptions)
            .SetValidator(new SortingOptionsValidator(SortableProperty));

        RuleFor(x => x.PagingOptions)
            .SetValidator(new PagingOptionsValidator());
    }
}

public class GetEventsQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetEventsQuery, Result<GetEventsResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    static GetEventsQueryHandler()
    {
        TypeAdapterConfig.GlobalSettings.Default.MapToConstructor(true);

        TypeAdapterConfig<UniversityUnit, UniversityUnitDto>
            .NewConfig()
            .Map(dest => dest.AvatarUrl, src => src.User.AvatarUrl);

        TypeAdapterConfig<Event, EventDto>
            .NewConfig()
            .Map(dest => dest.UniversityUnit, src => src.UniversityUnit.Adapt<UniversityUnitDto>())
            .Map(dest => dest.Type, src => src.Type.ToString())
            .Map(dest => dest.Images, src => src.Images.Select(i => i.Adapt<EventImageDto>()))
            .Map(dest => dest.TotalRegistration, src => src.Registrations.Count(e => e.IsRegistered));
    }

    public async Task<Result<GetEventsResponse>> Handle(GetEventsQuery request, CancellationToken cancellationToken)
    {
        var filter = request.Filter;

        var query = _dbContext.Events
            .AsQueryable();


        IQueryable<EventDto> dtoQuery;

        query = ApplySearch(query, filter.SearchTerm);
        query = ApplyFilter(query, filter);


        if (!query.Any())
            return Result.Failure<GetEventsResponse>(EventErrors.NotFound);

        var sortOptions = request.SortOptions;
        var student = await _dbContext.Students
            .Include(s => s.FollowedUnits)
            .Select(s => new
            {
                s.UserId,
                FollowedUnits = s.FollowedUnits.Select(fu => new { fu.UniversityUnitId }),
                s.Id
            })
            .FirstOrDefaultAsync(x => x.UserId == request.UserId, cancellationToken);

        if (filter.IsGetFollowing == true && student is not null)
        {
            var followedUnitIds = student.FollowedUnits.Select(u => u.UniversityUnitId);
            query = query.Where(x => followedUnitIds.Contains(x.UniversityUnitId));
        }

        dtoQuery = query
            .Include(x => x.Images)
            .Include(e => e.UniversityUnit)
                .ThenInclude(u => u.User)
            .Include(e => e.Registrations)
            .OrderBy(sortOptions.SortBy, sortOptions.SortAscending)
            .Select(x => x.Adapt<EventDto>());

        var events = await PaginatedList<EventDto>.CreateAsync(dtoQuery, request.PagingOptions.PageNumber, request.PagingOptions.PageSize);
        
       
        

        if (student is not null)
        {
            var registrations = await _dbContext.EventRegistrations
                .Where(r => r.StudentId == student.Id && r.IsRegistered)
                .ToListAsync(cancellationToken);

            events.Items.ForEach(e =>
            {
                e.IsThisStudentRegistered = registrations.Exists(r => r.EventId == e.Id);
            });
        }

        return new GetEventsResponse(events);
    }

    private static IQueryable<Event> ApplySearch(IQueryable<Event> query, string? searchTerm)
    {
        if (string.IsNullOrEmpty(searchTerm))
            return query;

        var isContainKeywords = searchTerm.Contains('\"');
        string formattedSearchText = string.Empty;
        
        if (!isContainKeywords)
        {
            searchTerm = "\"" + searchTerm.Trim() + "\"";
            formattedSearchText = SearchTextFormatter.FormatSearchTextWithOr(searchTerm);
        }
        else
        {
            formattedSearchText = SearchTextFormatter.FormatSearchTextWithAnd(searchTerm);
        }

        query = query.Where(x => EF.Functions.Contains(x.Title, formattedSearchText) || EF.Functions.Contains(x.Description, formattedSearchText));

        return query;
    }

    private static IQueryable<Event> ApplyFilter(IQueryable<Event> query, GetEventsFilter filter)
    {
        if (filter.StartDateRange is not null)
        {
            query = query.Where(x => x.StartDate >= filter.StartDateRange.Start && x.StartDate <= filter.StartDateRange.End);
        }
        
        if (filter.EndDateRange is not null)
        {
            query = query.Where(x => x.EndDate >= filter.EndDateRange.Start && x.EndDate <= filter.EndDateRange.End);
        }

        if (!string.IsNullOrEmpty(filter.Type))
            query = query.Where(x => x.Type == Enum.Parse<EventType>(filter.Type));


        if (filter.IsPublished.HasValue)
            query = query.Where(x => x.IsPublished == filter.IsPublished);



        return query;
    }
}