using Marble.Game.Providers;

namespace Marble.Game
{
    public class GameClient
    {
        private readonly WindowProvider windowProvider;

        public GameClient(
            WindowProvider windowProvider)
        {
            this.windowProvider = windowProvider;
        }

        public void Run()
        {
            var window = windowProvider.Window;
            window.Run();
            window.Dispose();
        }
    }
}
