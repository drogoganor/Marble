using Marble.Game.Providers;
using SDL2;
using static SDL2.SDL;

namespace Marble.Game
{
    public class GameClient
    {
        private readonly Sdl2WindowProvider windowProvider;
        private bool running = true;

        public GameClient(
            Sdl2WindowProvider windowProvider)
        {
            this.windowProvider = windowProvider;
        }

        // https://jsayers.dev/c-sharp-sdl-tutorial-part-1-setup/
        public void Run()
        {
            var renderer = windowProvider.Renderer;
            var window = windowProvider.Window;

            // Main loop for the program
            while (running)
            {
                // Check to see if there are any events and continue to do so until the queue is empty.
                while (SDL.SDL_PollEvent(out SDL.SDL_Event e) == 1)
                {
                    switch (e.type)
                    {
                        case SDL.SDL_EventType.SDL_QUIT:
                            running = false;
                            break;
                    }
                }

                // Sets the color that the screen will be cleared with.
                if (SDL.SDL_SetRenderDrawColor(renderer, 135, 206, 235, 255) < 0)
                {
                    Console.WriteLine($"There was an issue with setting the render draw color. {SDL.SDL_GetError()}");
                }

                // Clears the current render surface.
                if (SDL.SDL_RenderClear(renderer) < 0)
                {
                    Console.WriteLine($"There was an issue with clearing the render surface. {SDL.SDL_GetError()}");
                }

                // Switches out the currently presented render surface with the one we just did work on.
                SDL.SDL_RenderPresent(renderer);
            }

            // Clean up the resources that were created.
            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
            SDL.SDL_Quit();
        }
    }
}
