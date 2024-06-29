using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Common.Interfaces;

public interface IOtpService
{
    Result<bool> VerifyOtp(string emailAddress, string otp);
    Task<Result> SendOtpAsync(string emailAddress, string otp);
    Result<string> GenerateOtp(string emailAddress);
}
