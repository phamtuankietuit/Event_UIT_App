using MediatR;
using Microsoft.AspNetCore.Mvc;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Features.Users;

public class VerifyOtpController : ApiControllerBase
{
    [HttpPost("auth/verify-otp")]
    public async Task<IActionResult> VerifyOtp(
        [FromBody] VerifyOtpCommand command
    )
    {
        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record VerifyOtpResponse(bool IsVerified, string Message);

public record VerifyOtpCommand(string Email, string Otp) : IRequest<Result<VerifyOtpResponse>>;

public class VerifyOtpCommandHandler(
    IOtpService otpService    
) : IRequestHandler<VerifyOtpCommand, Result<VerifyOtpResponse>>
{
    private readonly IOtpService _otpService = otpService;

    public async Task<Result<VerifyOtpResponse>> Handle(VerifyOtpCommand request, CancellationToken cancellationToken)
    {
        var result = _otpService.VerifyOtp(request.Email, request.Otp);
        if (result.IsFailure)
            return Result.Failure<VerifyOtpResponse>(result.Error);

        return new VerifyOtpResponse(true, "Otp verified successfully");
    }
}

