namespace KKBookstore.Application.Common.Models;

public record TokenResponse(string AccessToken, DateTime AccessTokenExpiration, string RefreshToken);