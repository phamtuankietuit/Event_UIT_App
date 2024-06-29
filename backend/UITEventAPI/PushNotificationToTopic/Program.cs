using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices(services =>
    {
        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
        services.AddSingleton(services =>
        {
            var assembly = Assembly.GetExecutingAssembly();
            using var stream = assembly.GetManifestResourceStream("PushNotificationToTopic.private_key.json") ?? throw new FileNotFoundException("Embedded resource not found.");
            
            using var reader = new StreamReader(stream);
            var json = reader.ReadToEnd();
            var credential = GoogleCredential.FromJson(json);
            
            return FirebaseApp.Create(new AppOptions()
            {
                Credential = credential,
            });
        });
    })
    .Build();

host.Run();
