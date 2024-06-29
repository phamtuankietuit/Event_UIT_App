using Microsoft.AspNetCore.Identity;
using UITEventAPI.Application.Common.Constants;

namespace UITEventAPI.Application.Domain.Users;

public class User : IdentityUser<int>
{
    // Common properties
    public string AvatarUrl { get; set; } = ImageConstants.DefaultAvatarUrl;
    public bool IsActive { get; set; }
}
