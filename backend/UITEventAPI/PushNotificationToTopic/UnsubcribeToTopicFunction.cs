using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PushNotificationToTopic;

public class UnsubcribeToTopicFunction
{
    private readonly ILogger<UnsubcribeToTopicFunction> _logger;
    private readonly FirebaseApp _firebaseApp;

    public UnsubcribeToTopicFunction(ILogger<UnsubcribeToTopicFunction> logger, FirebaseApp firebaseApp)
    {
        _logger = logger;
        _firebaseApp = firebaseApp;
    }

    [Function(nameof(UnsubcribeToTopicFunction))]
    public async Task Run([QueueTrigger("unsubscribe-topic", Connection = "ConnectionString:queue")] string message)
    {
        var subscribeMessage = JsonConvert.DeserializeObject<SubscribeMessage>(message);

        //Unsubscribe to firebase topic using firebase admin sdk
        var messaging = FirebaseMessaging.GetMessaging(_firebaseApp);

        await messaging.UnsubscribeFromTopicAsync([subscribeMessage.Token], subscribeMessage.Topic);

        var response = $"Token = {subscribeMessage.Token}, Topic = {subscribeMessage.Topic}";
        _logger.LogInformation($"Unsubscribed to topic: {response}");
    }
}
