using System;
using VitPro;
using VitPro.Engine;

class Controller2 : IController
{
    public Vec2 dir()
    {
        if (Key.L.Pressed())
            return new Vec2(0, -1);
        if (Key.O.Pressed())
            return new Vec2(0, 1);
        return Vec2.Zero;
    }
}