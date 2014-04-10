using System;
using VitPro;
using VitPro.Engine;

public class Platform : IRenderable, IUpdateable
{
    public Vec2 pos1;
    public Vec2 pos2;
    public IController controller;
    public int score = 0;

    public Platform(Vec2 pos1, Vec2 pos2, IController cont)
    {
        this.pos1 = pos1;
        this.pos2 = pos2;
        controller = cont;
    }

    public void Render()
    {
        Draw.Rect(pos1, pos2, Color.Blue);
    }

    public void Update(double dt)
    {
        Vec2 t = controller.dir() * 200 * dt;

        if (pos2.Y > 105 && t.Y > 0)
            t = Vec2.Zero;

        if (pos1.Y < -105 && t.Y < 0)
            t = Vec2.Zero;

        pos1 += t;
        pos2 += t;
    }
}