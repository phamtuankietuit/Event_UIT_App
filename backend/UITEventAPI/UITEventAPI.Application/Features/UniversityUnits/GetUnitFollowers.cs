using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Infrastructure.Data;
using static UITEventAPI.Application.Features.UniversityUnits.GetUnitFollowersResponse;

namespace UITEventAPI.Application.Features.UniversityUnits;

public class GetUnitFollowersController : ApiControllerBase
{
    [HttpGet("university-units/{unitId}/followers")]
    public async Task<IActionResult> GetUnitFollowers([FromRoute] int unitId)
    {
        var result = await Sender.Send(new GetUnitFollowersQuery(unitId));
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetUnitFollowersResponse(List<UniversityUnitFollowerDto> Items, int Total)
{
    public sealed record UniversityUnitFollowerDto(int Id, string FullName, string Email, int StudentCode);
}

public record GetUnitFollowersQuery(int UnitId) : IRequest<Result<GetUnitFollowersResponse>>;

public class GetUnitFollowersQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetUnitFollowersQuery, Result<GetUnitFollowersResponse>>
{
    public async Task<Result<GetUnitFollowersResponse>> Handle(GetUnitFollowersQuery request, CancellationToken cancellationToken)
    {
        var followers = await dbContext.UnitFollows
            .Include(uf => uf.Student)
                .ThenInclude(s => s.User)
            .Where(x => x.UniversityUnitId == request.UnitId && x.Student.User.IsActive)
            .Select(x => new UniversityUnitFollowerDto(x.Student.Id, x.Student.FullName, x.Student.User.Email!, x.Student.StudentCode))
            .ToListAsync(cancellationToken);

        return new GetUnitFollowersResponse(followers, followers.Count);
    }
}
