﻿using System;
using System.Globalization;
using VitPro;
using VitPro.Engine;

public class Program
{
    static void Main(string[] args)
    {
        App.VSync = true;
        App.Title = "Pong game by VSKA";        
        
        App.Run(new Game());        
    }
}
