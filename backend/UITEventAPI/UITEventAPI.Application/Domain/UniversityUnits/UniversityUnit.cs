﻿using UITEventAPI.Application.Common;
using UITEventAPI.Application.Domain.Events;
using UITEventAPI.Application.Domain.Users;

namespace UITEventAPI.Application.Domain.UniversityUnits;

public class UniversityUnit : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string FacebookUrl { get; set; } = string.Empty;

    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Event> HostedEvents { get; set; } = [];
    public ICollection<UnitFollow> FollowedStudents { get; set; } = [];
}
