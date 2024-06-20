using Microsoft.AspNetCore.Identity;

namespace UITEventAPI.Application.Domain.Users;

public class User : IdentityUser<int>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName => $"{FirstName} {LastName}";
    public string AvatarUrl { get; set; }
    public DateTime DateOfBirth { get; set; }

    public string? StudentId { get; set; }
    public UserRole Role { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset DeletedWhen { get; set; }
}
