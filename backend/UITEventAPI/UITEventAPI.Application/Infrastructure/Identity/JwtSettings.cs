namespace UITEventAPI.Application.Infrastructure.Identity;

public class JwtSettings
{
    public string Secret { get; set; } = null!;
    public string Issuer { get; set; } = null!;
    public string Audience { get; set; } = null!;
    public int AccessExpirationInDays { get; set; }
    public int RefreshExpirationInMonths { get; set; }
}
