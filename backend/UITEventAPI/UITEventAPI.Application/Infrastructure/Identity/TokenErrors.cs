using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Infrastructure.Identity;

public static class TokenErrors
{
    public static readonly Error InvalidRefreshToken = Error.Unauthorized("Token.InvalidRefreshToken", "Invalid refresh token.");
}
