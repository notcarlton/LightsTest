using BombDetect;
using BombDetect.Core;
using static SDL2.SDL;

namespace LightsTest;

internal static class Program
{
    private static void Main()
    {
        Engine.Initialize("Lights Test", 100, 100, 800, 600, SDL_WindowFlags.SDL_WINDOW_SHOWN);
        var scene = new MainScene();
        SceneManager.AddScene("MainScene", scene);
        Engine.Run();
    }
}