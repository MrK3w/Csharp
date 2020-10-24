using System;
using System.Collections.Generic;
using System.Text;

namespace tetirs
{
    public class Tetromino
    {
        public int X;
        public int Y;
        public int Orientation;
        public ConsoleColor Color;
        public Brick[] tetrominoShape;

        public int Size { get; set; }

        public Tetromino(Brick[] tetrominoShape, int x, int y, int orientation, ConsoleColor color)
        {
            this.tetrominoShape = tetrominoShape;
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
            this.Color = color;
            this.Size = tetrominoShape.Length;
        }

        public Tetromino()
        {
        }

        public virtual void CreateBrick(Brick[] tetrominoShape,int x, int y, int orientation)
        {
        }

        public void TranslatePosition(int x, int y)
        {
            for (int i = 0; i < tetrominoShape.Length; i++)
            {
                tetrominoShape[i].PositionX += x;
                tetrominoShape[i].PositionY += y;
            }
        }
    }
    }
