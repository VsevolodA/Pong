using System;
using VitPro;
using VitPro.Engine;

public class Platform : IRenderable, IUpdateable
{
    public Vec2 pos;
    public Vec2 size;
    public IController controller;
    public int score = 0;

    public Platform(Vec2 pos, Vec2 size, IController cont)
    {
        this.pos = pos;
        this.size = size;
        controller = cont;
    }

    public void Render()
    {
        Draw.Rect(pos - size, pos + size, Color.Blue);
    }

    public void Update(double dt)
    {
        Vec2 t = controller.dir() * 200 * dt;

        if (pos.Y + size.Y > 105 && t.Y > 0)
            t = Vec2.Zero;

        if (pos.Y - size.Y < -105 && t.Y < 0)
            t = Vec2.Zero;

        pos += t;
    }

    public void isCollide (Ball ball)
    {
        double up, down, left, right, up2, down2, left2, right2;

        up = pos.Y + size.Y;
        down = pos.Y - size.Y;
        left = pos.X - size.X;
        right = pos.X + size.X;

        up2 = ball.pos.Y + ball.radius;
        down2 = ball.pos.Y - ball.radius;
        left2 = ball.pos.X - ball.radius;
        right2 = ball.pos.X + ball.radius;

        if (!(left > right2 || right < left2 || up < down2 || down > up2))
        {
            ball.to = (ball.pos - this.pos).Unit;
            ball.color = Color.Gray;
        }
    }
}