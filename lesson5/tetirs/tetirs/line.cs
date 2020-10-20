using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5
{
    class Line : Tetromino
    {
        public Line(Brick[] kostka, int x, int y, int orientation, ConsoleColor color) : base(kostka, x, y, orientation, color)
        {
            CreateBrick(kostka,x, y,orientation);
            Color = color;
        }
        public override void CreateBrick(Brick[] kostka, int x, int y,int orientation)
        {
            kostka[0].X = 0;
            kostka[1].X = 1;
            kostka[2].X = 2;
            kostka[3].X = 3;
            kostka[0].Y = 0;
            kostka[1].Y = 0;
            kostka[2].Y = 0;
            kostka[3].Y = 0;
            for (int i = 0; i < kostka.Length; i++)
            {
                kostka[i].X += x;
                kostka[i].Y += y;
            }

            if (orientation == 1)
            {
                for (int i = 0; i < kostka.Length; i++)
                {
                    int pom =  kostka[i].X;
                    kostka[i].X = 0;
                    kostka[i].Y += pom;
                }
            }
        }
    }
}
