using BombDetect;
using BombDetect.Objects;
using System.Numerics;

using static SDL2.SDL;

namespace LightsTest;

public class Light : Sprite
{
    private float _angle;
    private float _speed;
    private float _distance = 100;
    private Vector2 _centerScreen;
    private Vector2 _offsetPosition;

    private Random _random = new();

    public Light(string name, Vector2 position, string path) : base(name, position, path)
    {
        _angle = 0;
        _speed = _random.NextSingle() * 0.1f;
        _centerScreen = new(Window.OriginalResolution.X / 2, Window.OriginalResolution.Y / 2);
    }

    public override void Start()
    {
        base.Start();
        SDL_SetTextureBlendMode(Texture.TexturePointer, SDL_BlendMode.SDL_BLENDMODE_ADD);
    }

    public override void OnRender()
    {
        _angle += _speed;
        _offsetPosition = new(
            (float)Math.Cos(_angle) * _distance,
            (float)Math.Sin(_angle) * _distance
        );

        Position = _centerScreen + _offsetPosition;
        base.OnRender();
    }
}