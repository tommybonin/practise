using System;
using Dapr.Client;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", async (HttpContext context) =>
{
        const string storeName = "statestore";
        const string key = "counter";

        var daprClient = new DaprClientBuilder().Build();
        var counter = await daprClient.GetStateAsync<int>(storeName, key);
        return $"ex02:{counter}";

});

app.Run();
