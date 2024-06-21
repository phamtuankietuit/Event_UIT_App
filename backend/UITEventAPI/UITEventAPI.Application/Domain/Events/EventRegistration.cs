using UITEventAPI.Application.Common;
using UITEventAPI.Application.Domain.Students;

namespace UITEventAPI.Application.Domain.Events;

public class EventRegistration : AuditableEntity
{
    public int Id { get; set; }
    public bool IsRegistered { get; set; }
    public DateTime RegisterDate { get; set; }


    // Event information
    public int EventId { get; set; }
    public Event Event { get; set; } = null!;


    // Student information
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;

    // Attendance information
    public bool IsAttended { get; set; } = false;
    public DateTime? AttendedDate { get; set; }
}
