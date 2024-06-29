using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PushNotificationToTopic;

public class PushNotificationFunction
{
    private readonly ILogger<PushNotificationFunction> _logger;
    private FirebaseApp _firebaseApp;

    public PushNotificationFunction(ILogger<PushNotificationFunction> logger, FirebaseApp firebaseApp)
    {
        _logger = logger;
        _firebaseApp = firebaseApp;
    }

    [Function(nameof(PushNotificationFunction))]
    public async Task Run([QueueTrigger("event-message", Connection = "ConnectionString:queue")] string message)
    {
        var eventMessage = JsonConvert.DeserializeObject<EventMessage>(message);

        var firebaseMessage = new Message()
        {
            Data = new Dictionary<string, string>()
            {
                { "title", eventMessage.Title },
                { "body", eventMessage.Body },
                { "mydata", "1337" }
            },
            Notification = new Notification()
            {
                Title = eventMessage.Title,
                Body = eventMessage.Body
            },
            Topic = eventMessage.Topic,
        };

        var messaging = FirebaseMessaging.GetMessaging(_firebaseApp);
        var response = await messaging.SendAsync(firebaseMessage);

        //var response = $"Title = {eventMessage.Title}, Topic = {eventMessage.Topic}, Body = {eventMessage.Body}";
        _logger.LogInformation($"Notification sent: {response}");
    }
}

public class EventMessage
{
    public string Topic { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}