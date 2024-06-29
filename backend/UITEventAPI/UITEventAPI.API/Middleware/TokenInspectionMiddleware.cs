using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace UITEventAPI.API.Middleware
{
    public class TokenInspectionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TokenInspectionMiddleware> _logger;

        public TokenInspectionMiddleware(RequestDelegate next, ILogger<TokenInspectionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Capture and log the Authorization header
            if (context.Request.Headers.TryGetValue("Authorization", out var authHeader))
            {
                _logger.LogInformation("Authorization Header: {AuthHeader}", authHeader);

                // Inspect the token further (decode, check claims, etc.) 

                var header = authHeader.ToString();
                var token = header.Split(" ")[1];

                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token) as JwtSecurityToken;
                if (jsonToken != null) {
                    _logger.LogInformation("Token Issuer: {Issuer}", jsonToken.Issuer);
                    _logger.LogInformation("Token Audience: {Audience}", jsonToken.Audiences.FirstOrDefault());
                    _logger.LogInformation("Token Subject: {Subject}", jsonToken.Subject);
                    _logger.LogInformation("Token Valid From: {ValidFrom}", jsonToken.ValidFrom);
                    _logger.LogInformation("Token Valid To: {ValidTo}", jsonToken.ValidTo);
                    // Validate the token and set the user context
                    var validationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "https://y3s2-uitevent.azurewebsites.net/", // Replace with your issuer
                        ValidAudience = "https://y3s2-uitevent.azurewebsites.net/", // Replace with your audience
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("vRLrTN4ifgSfNh/CiCKA3EJTjtRCsvCEXB326Kni31AmKvvFtIBlfmsgeFJzjVAb3dDwoCov2JFk3uF/Zw/9N/nNTBtDf12+425bC+vwZG0RelUHSdzx7eTO8SmfDU+MtvEXvjL5G+/gTtOQ70uK8XWuZt5bbRUpn8RGbYpelJ8rLtk7w7nCDSkT3nUfd4wkdgR6BnxvfrIrHumHjyLb8kNQeXSdtWVPg3t/UzU2nX3ANRDnhcR6TgqE3uGElcbX4s1m0KQPoOpykhr6CCv4QFkuILU8lwABZZh2hbAf811s++Fh8VsDRXzor2zU45UujRde/QtTqJ2np7+05ltXgA==")) // Replace with your secret key
                    };

                    try
                    {
                        SecurityToken validatedToken;
                        var principal = handler.ValidateToken(token, validationParameters, out validatedToken);
                        context.User = principal; // Set the authenticated user
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("Token validation failed: {Exception}", ex.Message);
                    }
                }
                else
                {
                    _logger.LogInformation("Invalid token");
                }
            }

            // Call the next middleware in the pipeline
            await _next(context);
        }
    }
}
