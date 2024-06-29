using KKBookstore.Application.Common.Models;

namespace UITEventAPI.Application.Common.Models;

public record TokenResponseWithRole(string AccessToken, DateTime AccessTokenExpiration, string RefreshToken, string Role
    ) : TokenResponse(AccessToken, AccessTokenExpiration, RefreshToken);