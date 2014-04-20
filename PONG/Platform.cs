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

    public void isCollide (Ball ball)
    {
        /*
        if (ball.pos.Y <= this.pos2.Y &&
            ball.pos.Y >= this.pos1.Y &&
            Math.Abs(ball.pos.X - this.pos2.X) <= ball.radius)
        {

            
            //ball.color = Color.Yellow;
        }
        */

        double up, down, left, right, up2, down2, left2, right2;

        up = pos2.Y;
        down = pos1.Y;
        left = pos1.X;
        right = pos2.X;

        up2 = ball.pos.Y + ball.radius;
        down2 = ball.pos.Y - ball.radius;
        left2 = ball.pos.X + ball.radius;
        right2 = ball.pos.X - ball.radius;

        if (!(left > right2 || right < left2 || up < down2 || down > up))
        {
            ball.to = new Vec2(-this.pos1.X / this.pos1.Length, ball.to.Y);
            ball.color = Color.Gray;
        }
    }
}