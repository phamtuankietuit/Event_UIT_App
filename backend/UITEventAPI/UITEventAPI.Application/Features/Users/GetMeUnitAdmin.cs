using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.UniversityUnit;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Users;

// GetMeUnitAdmin
public class GetMeUnitAdminController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.UnitAdmin)]
    [HttpGet("users/unit-admin/me")]
    public async Task<IActionResult> GetMeUnitAdmin()
    {
        var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userIdValue is null)
        {
            return Unauthorized();
        }

        var result = await Sender.Send(new GetMeUnitAdminQuery(int.Parse(userIdValue)));
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetMeUnitAdminResponse(
    int Id,
    string Name,
    string Email,
    string PhoneNumber,
    DateTimeOffset DateOfBirth,
    string AvatarUrl,
    string Role
);

public record GetMeUnitAdminQuery(int UserId) : IRequest<Result<GetMeUnitAdminResponse>>;

public class GetMeUnitAdminHandler(
    ApplicationDbContext dbContext   
) : IRequestHandler<GetMeUnitAdminQuery, Result<GetMeUnitAdminResponse>>
{
    static GetMeUnitAdminHandler()
    {
        TypeAdapterConfig<UniversityUnit, GetMeUnitAdminResponse>
            .NewConfig()
            .Map(dest => dest.Email, src => src.User.Email)
            .Map(dest => dest.PhoneNumber, src => src.User.PhoneNumber)
            .Map(dest => dest.AvatarUrl, src => src.User.AvatarUrl);
    }

    public async Task<Result<GetMeUnitAdminResponse>> Handle(GetMeUnitAdminQuery request, CancellationToken cancellationToken)
    {
        var universityUnit = await dbContext.UniversityUnits
            .Where(s => s.UserId == request.UserId)
            .Include(s => s.User)
            .Where(s => s.User.IsActive)
            .FirstOrDefaultAsync(cancellationToken);

        if (universityUnit is null)
        {
            return Result.Failure<GetMeUnitAdminResponse>(UserErrors.NotFound);
        }

        var UniversityUnitDto = universityUnit.Adapt<GetMeUnitAdminResponse>() with
        {
            Role = UserRoleConstants.UnitAdmin
        };

        return Result.Success(UniversityUnitDto);
    }
}