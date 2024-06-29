using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Users;

public class GetMeUniversityAdminController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.UniversityAdmin)]
    [HttpGet("users/university-admin/me")]
    public async Task<IActionResult> GetMeUniversityAdmin()
    {
        var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userIdValue is null)
        {
            return Unauthorized();
        }

        var result = await Sender.Send(new GetMeUniversityAdminQuery(int.Parse(userIdValue)));
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetMeUniversityAdminResponse(
    int Id,
    string Email,
    string PhoneNumber,
    DateTimeOffset DateOfBirth,
    string AvatarUrl,
    string Role
);

public record GetMeUniversityAdminQuery(int UserId) : IRequest<Result<GetMeUniversityAdminResponse>>;

public class GetMeUniversityAdminHandler(
    ApplicationDbContext dbContext    
) : IRequestHandler<GetMeUniversityAdminQuery, Result<GetMeUniversityAdminResponse>>
{
    public async Task<Result<GetMeUniversityAdminResponse>> Handle(GetMeUniversityAdminQuery request, CancellationToken cancellationToken)
    {
        var admin = await dbContext.Users.FirstOrDefaultAsync(u => u.Id == request.UserId && u.IsActive, cancellationToken);

        if (admin is null)
        {
            return Result.Failure<GetMeUniversityAdminResponse>(UserErrors.NotFound);
        }

        var adminDto = admin.Adapt<GetMeUniversityAdminResponse>() with
        {
            Role = UserRoleConstants.UniversityAdmin
        };

        return adminDto;
    }
}