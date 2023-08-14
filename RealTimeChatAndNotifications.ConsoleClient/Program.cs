// See https://aka.ms/new-console-template for more information
using Microsoft.AspNetCore.SignalR.Client;

try
{
    Console.WriteLine("Hello, World!");
    //Set connection
    var connection = new HubConnectionBuilder()
                .WithUrl("wss://localhost:7091/notifications-hub")
                .Build();
    //connection.On<string>("BroadCastNotificaiton", (user, message) =>
    //{
    //    Console.WriteLine(message);
    //});
    await connection.StartAsync();

    Console.WriteLine("Press any key to exit");

    connection.On<string>("BroadCastNotificaiton", (message) =>
    {
        Console.WriteLine(message);
    });
    Console.ReadKey();
}
catch (Exception)
{
    Console.WriteLine();
}