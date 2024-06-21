using Microsoft.AspNetCore.Identity;
using UITEventAPI.Application.Common.Constants;
using UITEventAPI.Application.Domain.Students;
using UITEventAPI.Application.Domain.UniversityUnit;

namespace UITEventAPI.Application.Domain.Users;

public class User : IdentityUser<int>
{
    // Common properties
    public string AvatarUrl { get; set; } = ImageConstants.DefaultAvatarUrl;
    public bool IsActive { get; set; }
}
