using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Extensions;

namespace UITEventAPI.Application.Features.Users;

public class ChangePasswordController : ApiControllerBase
{
    [Authorize]
    [HttpPost("users/change-password")]
    public async Task<IActionResult> ChangePassword(
        [FromBody] ChangePassword command
    )
    {
        var userId = User.GetUserId();

        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record ChangePasswordResponse(string Message);

public class ChangePassword : IRequest<Result<ChangePasswordResponse>>
{
    public string Email { get; set; }
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
}

public class ChangePasswordHandler(
    IIdentityService identityService
) : IRequestHandler<ChangePassword, Result<ChangePasswordResponse>>
{
    private readonly IIdentityService _identityService = identityService;

    public async Task<Result<ChangePasswordResponse>> Handle(ChangePassword request, CancellationToken cancellationToken)
    {
        var result = await _identityService.ChangePasswordAsync(request.Email, request.OldPassword, request.NewPassword, cancellationToken);
        if (result.IsFailure)
            return Result.Failure<ChangePasswordResponse>(result.Error);

        return new ChangePasswordResponse("Password changed successfully");
    }
}