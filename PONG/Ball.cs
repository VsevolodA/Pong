using System;
using VitPro;
using VitPro.Engine;

public class Ball : State
{
    public Vec2 pos;
    public double radius;
    public Vec2 to = new Vec2(-1, -0.5);
    public Color color = Color.Blue;

    public Ball(Vec2 pos, double radius)
    {
        this.pos = pos;
        this.radius = radius;
    }

    public override void Render()
    {
        Draw.Circle(pos, radius, color);
    }

    public void go(double dt)
    {
        pos += to * dt * 100;
    }
}