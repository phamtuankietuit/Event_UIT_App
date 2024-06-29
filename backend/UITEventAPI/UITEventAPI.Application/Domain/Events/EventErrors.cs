using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Domain.Events;

public static class EventErrors
{
    public static readonly Error NotFound = Error.NotFound("Event.NotFound", "Event not found.");
    public static readonly Error Unauthorized = Error.Unauthorized("Event.Unauthorized", "Unauthorized to perform this action.");
    public static readonly Error MaxAttendeesExceedRegisteredCount = Error.Conflict("Event.MaxAttendeesExceedRegisteredCount", "Max attendees cannot be less than the number of registered attendees.");
    public static readonly Error UpdateFailed = Error.Failure("Event.UpdateFailed", "Failed to update event.");
    public static readonly Error CreateFailed = Error.Failure("Event.CreateFailed", "Failed to create event.");
    public static readonly Error InvalidImageBase64Format = Error.Validation("Event.InvalidImageBase64Format", "Invalid image base64 format.");





    public static Error NotChangeable(string propertyName) => Error.Conflict("Event.PropertyNotChangeable", $"Property {propertyName} cannot be modified.");
    
    // Attendance errors
    public static readonly Error EventNotStarted = Error.Conflict("Attendance.EventNotStarted", "Event has not started yet.");
    public static readonly Error EventEnded = Error.Conflict("Attendance.EventEnded", "Event has ended.");
    public static readonly Error EventNotEnded = Error.Conflict("Attendance.EventNotEnded", "Event has not ended yet.");
    public static readonly Error OnlyAvailableAfterEventStart = Error.Conflict("Attendance.OnlyAvailableAfterEventStart", "Check-in is only available after the event starts.");
    public static readonly Error AttendanceNotFound = Error.NotFound("Attendance.NotFound", "Attendance not found.");
    public static readonly Error AttendeeNotFound = Error.NotFound("Attendance.AttendeeNotFound", "Attendee not found.");
    public static readonly Error CheckinFailed = Error.Failure("Attendance.CheckinFailed", "Failed to check-in.");

    // Registration errors
    public static readonly Error OnlyAvailableBeforeEventStart = Error.Conflict("Registration.OnlyAvailableBeforeEventStart", "Registration is only available before the event starts.");
    public static readonly Error StudentNotFound = Error.NotFound("Registration.StudentNotFound", "Student not found.");
    public static readonly Error AlreadyRegistered = Error.Conflict("Registration.AlreadyRegistered", "Student has already registered for this event.");
}
