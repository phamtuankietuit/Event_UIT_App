using Microsoft.Extensions.Caching.Memory;
using UITEventAPI.Application.Common;
using UITEventAPI.Application.Common.Interfaces;
using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Infrastructure.Email;

public class OtpService(
    IMemoryCache cache,
    IEmailService emailService,
    IIdentityService identityService
) : IOtpService
{
    private readonly IMemoryCache _cache = cache;
    private readonly IEmailService _emailService = emailService;

    public Result<string> GenerateOtp(string emailAddress)
    {
        var existingOtp = _cache.Get<string>(emailAddress);

        if (!string.IsNullOrEmpty(existingOtp))
        {
            return Result.Success(existingOtp);
        }

        var otp = new Random().Next(100000, 999999).ToString();

        _cache.Set(emailAddress, otp, TimeSpan.FromMinutes(3));

        return otp;
    }

    public async Task<Result> SendOtpAsync(string emailAddress, string otp)
    {
        try
        {
            await _emailService.SendOtp(emailAddress, otp);
        }
        catch
        {
            return Result.Failure(ApplicationErrors.OtpSentFailed);
        }

        return Result.Success();
    }

    public Result<bool> VerifyOtp(string emailAddress, string otp)
    {
        if (_cache.TryGetValue(emailAddress, out string? existingOtp))
        {
            if (!string.IsNullOrEmpty(existingOtp) && existingOtp == otp)
            {
                _cache.Remove(emailAddress);

                return Result.Success(true);
            }
            else
            {
                // OTP is incorrect
                return Result.Failure<bool>(ApplicationErrors.OtpIncorrect);
            }
        }

        // OTP is expired
        return Result.Failure<bool>(ApplicationErrors.OtpExpired);
    }
}
