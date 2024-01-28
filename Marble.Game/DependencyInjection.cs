using Autofac;
using System.IO;
using System;
using Marble.Game.Providers;

namespace Marble.Game
{
    public static class DependencyInjection
    {
        public static ContainerBuilder Build()
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterType<Sdl2WindowProvider>()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();

            builder
                .RegisterType<GameClient>()
                .AsSelf()
                .AsImplementedInterfaces()
                .SingleInstance();

            return builder;
        }
    }
}
