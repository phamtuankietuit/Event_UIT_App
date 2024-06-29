using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Users;

public class GetUserController : ApiControllerBase
{
    [HttpGet("users/{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
        var result = await Sender.Send(new GetUserQuery(id));
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record GetUserResponse(
    int Id,
    string? Email,
    string? PhoneNumber,
    DateTimeOffset DateOfBirth,
    string? AvatarUrl
);

public record GetUserQuery(int UserId) : IRequest<Result<GetUserResponse>>;

public class GetUserQueryHandler(
    ApplicationDbContext dbContext
) : IRequestHandler<GetUserQuery, Result<GetUserResponse>>
{
    public async Task<Result<GetUserResponse>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var user = await dbContext.Users
            .Where(u => u.IsActive)
            .FirstOrDefaultAsync(u => u.Id == request.UserId, cancellationToken);

        if (user is null)
        {
            return Result.Failure<GetUserResponse>(UserErrors.NotFound);
        }

        var userDto = user.Adapt<GetUserResponse>();

        return Result.Success(userDto);
    }
}