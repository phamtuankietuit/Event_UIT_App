using Azure.Storage.Queues;
using Newtonsoft.Json;
using System.Text;
using UITEventAPI.Application.Common.Interfaces;

namespace UITEventAPI.Application.Infrastructure.Notification;

public class NotificationService(
    QueueServiceClient queueServiceClient
) : INotificationService
{
    private readonly QueueServiceClient _queueServiceClient = queueServiceClient;

    public async Task SendNotificationAsync(string topic, string title, string body)
    {
        var queueClient = _queueServiceClient.GetQueueClient("event-message");
        var message = new EventMessage
        {
            Topic = topic,
            Title = title,
            Body = body
        };

        var messageBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message)));
        await queueClient.SendMessageAsync(messageBase64);
    }

    public async Task SubcribeToTopicAsync(string topic, string token)
    {
        var queueClient = _queueServiceClient.GetQueueClient("subscribe-topic");
        var message = new SubscribeMessage
        {
            Topic = topic,
            Token = token
        };

        var messageBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message)));
        await queueClient.SendMessageAsync(messageBase64);
    }

    public async Task UnSubcribeToTopicAsync(string topic, string token)
    {
        var queueClient = _queueServiceClient.GetQueueClient("unsubscribe-topic");
        var message = new SubscribeMessage
        {
            Topic = topic,
            Token = token
        };

        var messageBase64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message)));
        await queueClient.SendMessageAsync(messageBase64);
    }
}


public class SubscribeMessage
{
    public string Topic { get; set; }
    public string Token { get; set; }
}

public class EventMessage
{
    public string Topic { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
