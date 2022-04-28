using BombDetect;
using BombDetect.Core;
using BombDetect.Objects;

using static SDL2.SDL;

namespace LightsTest;

public class MainScene : Scene
{
    private List<Light> _lights = new();

    public MainScene()
    {
        Console.WriteLine("MainScene created");

        _lights.Add(new Light("RedLight", new(), "resources/red.png"));
        _lights.Add(new Light("GreenLight", new(), "resources/green.png"));
        _lights.Add(new Light("BlueLight", new(), "resources/blue.png"));

        foreach (var light in _lights)
        {
            Things.Add(light);
        }

        Start();
    }
}