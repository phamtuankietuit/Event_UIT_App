using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;
using UITEventAPI.Application.Domain.Users;
using UITEventAPI.Application.Infrastructure.Data;

namespace UITEventAPI.Application.Features.Authentication;

public class ResetPasswordController : ApiControllerBase
{
    [HttpPost("auth/reset-password")]
    public async Task<IActionResult> ResetPassword(
        [FromBody] ResetPasswordCommand command
    )
    {
        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record ResetPasswordResponse(bool IsSuccess, string Message);

public record ResetPasswordCommand(string Email, string NewPassword, bool IsVerified) : IRequest<Result<ResetPasswordResponse>>;

public class ResetPasswordCommandHandler(
    ApplicationDbContext dbContext,
    IIdentityService identityService
) : IRequestHandler<ResetPasswordCommand, Result<ResetPasswordResponse>>
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    private readonly IIdentityService _identityService = identityService;

    public async Task<Result<ResetPasswordResponse>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        if (!request.IsVerified)
            return Result.Failure<ResetPasswordResponse>(UserErrors.OtpNotVerified);

        var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken);
        if (user == null)
            return Result.Failure<ResetPasswordResponse>(UserErrors.NotFound);

        var newPassword = request.NewPassword;
        var result = await _identityService.UpdatePasswordAsync(request.Email, newPassword, cancellationToken);

        if (result.IsFailure)
            return Result.Failure<ResetPasswordResponse>(result.Error);

        return new ResetPasswordResponse(true, "Password reset successfully");

    }
}