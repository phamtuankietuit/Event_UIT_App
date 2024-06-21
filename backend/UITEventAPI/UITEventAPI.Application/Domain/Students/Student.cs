using UITEventAPI.Application.Common;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Domain.Students;

public class Student : AuditableEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}";
    public DateTime DateOfBirth { get; set; }

    public User User { get; set; } = null!;
    // mssv
    public int StudentCode { get; set; }
    public ICollection<EventRegistration> RegisteredEvents { get; set; } = [];
}
