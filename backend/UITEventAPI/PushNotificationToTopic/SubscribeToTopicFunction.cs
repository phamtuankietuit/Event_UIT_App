using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PushNotificationToTopic;

public class SubscribeToTopicFunction
{
    private readonly ILogger<SubscribeToTopicFunction> _logger;
    private readonly FirebaseApp _firebaseApp;

    public SubscribeToTopicFunction(ILogger<SubscribeToTopicFunction> logger, FirebaseApp firebaseApp)
    {
        _logger = logger;
        _firebaseApp = firebaseApp;
    }

    [Function(nameof(SubscribeToTopicFunction))]
    public async Task Run([QueueTrigger("subscribe-topic", Connection = "ConnectionString:queue")] string message)
    {
        var subscribeMessage = JsonConvert.DeserializeObject<SubscribeMessage>(message);

        //Subscribe to firebase topic using firebase admin sdk
        var messaging = FirebaseMessaging.GetMessaging(_firebaseApp);

        await messaging.SubscribeToTopicAsync([subscribeMessage.Token], subscribeMessage.Topic);

        var response = $"Token = {subscribeMessage.Token}, Topic = {subscribeMessage.Topic}";
        _logger.LogInformation($"Subscribed to topic: {response}");
    }
}
