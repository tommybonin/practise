using Dapr.Client;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", async () =>
{
    const string storeName = "statestore";
    const string key = "counter";

    var daprClient = new DaprClientBuilder().Build();
    var counter = await daprClient.GetStateAsync<int>(storeName, key);
    await daprClient.SaveStateAsync(storeName, key, counter);

});

app.Run();
