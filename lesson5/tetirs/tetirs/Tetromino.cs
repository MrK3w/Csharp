using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5
{
    public class Tetromino
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Orientation { get; set; }
        public ConsoleColor Color { get; set; }
        public Brick[] Kostka { get; set; }

        public int size { get; set; }

        public Tetromino(Brick[] Kostka, int x, int y, int orientation, ConsoleColor color)
        {
            this.Kostka = Kostka;
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
            this.Color = color;
            this.size = Kostka.Length;
        }

        public Tetromino()
        {
        }

        public virtual void CreateBrick(Brick[] Kostka,int x, int y, int orientation)
        {
        }
    }
    }
