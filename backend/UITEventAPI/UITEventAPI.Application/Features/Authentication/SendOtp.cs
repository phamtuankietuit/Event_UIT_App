using MediatR;
using Microsoft.AspNetCore.Mvc;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Features.Authentication;

public class SendOtpController : ApiControllerBase
{
    [HttpPost("auth/send-otp")]
    public async Task<IActionResult> SendOtp(
        [FromBody] SendOtpCommand command
    )
    {
        var result = await Sender.Send(command);
        return result.IsSuccess ? Ok(result.Value) : ToActionResult(result);
    }
}

public record SendOtpResponse(bool IsSent, string Message);

public record SendOtpCommand(string Email) : IRequest<Result<SendOtpResponse>>;

public class SendOtpCommandHandler(
    IOtpService otpService
) : IRequestHandler<SendOtpCommand, Result<SendOtpResponse>>
{
    private readonly IOtpService _otpService = otpService;

    public async Task<Result<SendOtpResponse>> Handle(SendOtpCommand request, CancellationToken cancellationToken)
    {
        var genOtpResult = _otpService.GenerateOtp(request.Email);
        if (genOtpResult.IsFailure)
            return Result.Failure<SendOtpResponse>(genOtpResult.Error);

        var result = await _otpService.SendOtpAsync(request.Email, genOtpResult.Value);
        if (result.IsFailure)
            return Result.Failure<SendOtpResponse>(result.Error);

        return new SendOtpResponse(true, "Otp sent successfully");
    }
}
