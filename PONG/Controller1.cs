using System;
using VitPro;
using VitPro.Engine;

class Controller1 : IController
{
    public Vec2 dir()
    {
        if (Key.S.Pressed())
            return new Vec2(0, -1);
        if (Key.W.Pressed())
            return new Vec2(0, 1);
        return Vec2.Zero;
    }
}