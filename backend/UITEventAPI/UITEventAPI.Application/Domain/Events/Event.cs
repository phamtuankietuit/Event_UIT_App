﻿using UITEventAPI.Application.Common;
using UITEventAPI.Application.Domain.UniversityUnit;

namespace UITEventAPI.Application.Domain.Events;

public class Event : AuditableEntity
{
    public int Id { get; set; }

    public string Title { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsPublished { get; set; } = false;
    public string FormUrl { get; set; } = null!;
    public EventType Type { get; set; }
    public int TrainingPoint { get; set; } = 0;

    // Restriction
    public int MaxAttendees { get; set; }


    // the unit that host this event
    public int UniversityUnitId { get; set; }
    public UniversityUnit.UniversityUnit UniversityUnit { get; set; } = null!;

    // Soft delete
    public bool IsDeleted { get; set; }
    public DateTimeOffset DeletedWhen { get; set; }

    public ICollection<EventImage> Images { get; set; }
    public ICollection<EventRegistration> Registrations { get; set; } = [];
}
