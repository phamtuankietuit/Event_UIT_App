using UITEventAPI.Application.Common.Models;

namespace UITEventAPI.Application.Domain.Events;

public static class EventErrors
{
    public static readonly Error NotFound = Error.NotFound("Event.NotFound", "Event not found.");
}
