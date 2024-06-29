using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.UniversityUnits.GetUniversityUnitsResponse;

namespace UITEventAPI.Application.Features.UniversityUnits;

public class GetUniversityUnitsController : ApiControllerBase
{
    [HttpGet("university-units")]
    public async Task<IActionResult> GetUniversityUnits([FromQuery] GetUniversityUnitsQuery query)
    {
        var result = await Sender.Send(query);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetUniversityUnitsResponse(List<UniversityUnitDto> Items, int Total)
{
    public sealed record UniversityUnitDto(
        int Id,
        string Name,
        string Description,
        string FacebookUrl,
        string AvatarUrl,
        int TotalFollowers)
    {
        public bool? IsThisStudentFollowed { get; set; } = null;
    }
}

public record GetUniversityUnitsQuery(int? StudentId) : IRequest<Result<GetUniversityUnitsResponse>>;

public class GetUniversityUnitsQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetUniversityUnitsQuery, Result<GetUniversityUnitsResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<Result<GetUniversityUnitsResponse>> Handle(GetUniversityUnitsQuery request, CancellationToken cancellationToken)
    {
        var universityUnits = await _dbContext.UniversityUnits
            .OrderBy(x => x.Name)
            .ThenBy(x => x.CreatedDate)
            .Include(u => u.User)
            .ToListAsync(cancellationToken);

        var unitFollows = await _dbContext.UnitFollows
            .ToListAsync(cancellationToken);


        var response = universityUnits.Select(u =>
        {
            var totalFollows = unitFollows.Count(x => x.UniversityUnitId == u.Id && x.IsFollowed);
            bool? isStudentFollowed = request.StudentId.HasValue ? unitFollows.Exists(x => x.UniversityUnitId == u.Id && x.StudentId == request.StudentId && x.IsFollowed) : null;

            return new UniversityUnitDto(
                u.Id,
                u.Name,
                u.Description,
                u.FacebookUrl,
                u.User.AvatarUrl,
                totalFollows
            )
            {
                IsThisStudentFollowed = isStudentFollowed
            };
        }).ToList();


        return new GetUniversityUnitsResponse(response, universityUnits.Count);
    }
}
