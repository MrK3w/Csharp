using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lesson5
{
    class Tblock : Tetromino
    {
        public Tblock(Brick[] kostka, int x, int y, int orientation, ConsoleColor color) : base(kostka, x, y, orientation, color)
        {
            CreateBrick(kostka,x, y);
            Color = color;
        }
        public override void CreateBrick(Brick[] kostka,int x, int y)
        {
            kostka[0].X = 1;
            kostka[0].Y = 0;
            kostka[1].X = 0;
            kostka[1].Y = 1;
            kostka[2].X = 1;
            kostka[2].Y = 1;
            kostka[3].X = 2;
            kostka[3].Y = 1;
            for (int i = 0; i < kostka.Length; i++)
            {
                kostka[i].X += x;
                kostka[i].Y += y;
            }
        }
    }
}