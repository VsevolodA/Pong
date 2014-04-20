using System;
using VitPro;
using VitPro.Engine;

public class Robot : IRenderable, IUpdateable
{
    Platform plat;

    public Robot(Platform plat)
    {
        this.plat = plat;
    }

    public void toPlay(Vec2 ballpos)
    {
    }

    public void Render()
    {
        throw new NotImplementedException();
    }

    public void Update(double dt)
    {
        throw new NotImplementedException();
    }
}