using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.Web;

public class CurrentUserService(IHttpContextAccessor httpContextAccessor) : ICurrentUserService
{
    private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

    public int? Id
    {
        get
        {
            var idString = _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(idString) || !int.TryParse(idString, out int id))
            {
                return null;
            }

            return id;
        }
    }

}
