using Autofac;
using Marble.Game;
using Marble.Game.Providers;

var builder = DependencyInjection.Build();

var container = builder
    .Build();

GameClient client;
try
{
    client = container.Resolve<GameClient>();
}
catch (Exception ex)
{
    //var log = container.Resolve<ILogger>();
    //log.Error(ex, "Error creating GameClient");
    throw;
}

client.Run();
