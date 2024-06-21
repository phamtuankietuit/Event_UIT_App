using UITEventAPI.Application.Common.Constants;

namespace UITEventAPI.Application.Domain.Events;

public class EventImage
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = ImageConstants.DefaultImageUrl;
    
    public int EventId { get; set; }
    public Event Event { get; set; } = null!;
}
