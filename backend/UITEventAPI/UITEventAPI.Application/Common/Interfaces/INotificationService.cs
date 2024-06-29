namespace UITEventAPI.Application.Common.Interfaces;

public interface INotificationService
{
    Task SendNotificationAsync(string topic, string title, string body);
    Task SubcribeToTopicAsync(string topic, string token);
    Task UnSubcribeToTopicAsync(string topic, string token);
}
