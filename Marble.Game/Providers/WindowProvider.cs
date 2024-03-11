using Marble.Game.TK;

namespace Marble.Game.Providers
{
    public class WindowProvider : IDisposable
    {
        public readonly Window Window;

        public WindowProvider()
        {
            Window = new Window(1024, 768, "OpenTK");
        }

        public void Dispose()
        {
            Window.Dispose();
        }
    }
}
