using Mapster;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Users;

public class GetMeStudentController : ApiControllerBase
{
    [Authorize(Roles = UserRoleConstants.Student)]
    [HttpGet("users/students/me")]
    public async Task<IActionResult> GetMe()
    {
        var userIdValue = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (userIdValue is null)
        {
            return Unauthorized();
        }

        var result = await Sender.Send(new GetMeStudentQuery(int.Parse(userIdValue)));

        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetMeStudentResponse(
    int Id, 
    string FirstName, 
    string LastName,
    string Email,
    string PhoneNumber,
    DateTimeOffset DateOfBirth,
    string AvatarUrl,
    string Role
);

public record GetMeStudentQuery(int UserId) : IRequest<Result<GetMeStudentResponse>>;

public class GetMeStudentHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetMeStudentQuery, Result<GetMeStudentResponse>>
{
    /*
     *  This is for mapping Student to GetMeStudentResponse,
     *  Marked it as static for following reason:
     *      - This method will be called only once when the class is loaded into memory
     *      - Thread safe
     *      - Performance: no need to create a new instance of TypeAdapterConfig every time the Handler is instantiated
     */
    static GetMeStudentHandler()
    {
        TypeAdapterConfig<Student, GetMeStudentResponse>
            .NewConfig()
            .Map(dest => dest.Email, src => src.User.Email)
            .Map(dest => dest.PhoneNumber, src => src.User.PhoneNumber)
            .Map(dest => dest.AvatarUrl, src => src.User.AvatarUrl);
    }

    public async Task<Result<GetMeStudentResponse>> Handle(GetMeStudentQuery request, CancellationToken cancellationToken)
    {
        var student = await dbContext.Students
            .Where(s => s.UserId == request.UserId)
            .Include(u => u.User)
            .Where(s => s.User.IsActive)
            .FirstOrDefaultAsync(cancellationToken);

        if (student is null)
        {
            return Result.Failure<GetMeStudentResponse>(UserErrors.NotFound);
        }

        var userDto = student.Adapt<GetMeStudentResponse>() with
        {
            Role = UserRoleConstants.Student
        };

        return Result.Success(userDto);
    }
}
