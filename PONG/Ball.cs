using System;
using VitPro;
using VitPro.Engine;

public class Ball : IRenderable, IUpdateable
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
    
    public void Render()
    {
        Draw.Circle(pos, radius, color);
    }

    double up = 0;
    double t = 0;
    public void go(double dt)
    {
        t += dt;
        pos += to * dt * (120 + up);
        if (t >= 1)
        {
            up += 1;
            t = 0;
        }
    }

    public void Update(double dt)
    {
        throw new NotImplementedException();
    }
}