﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tetirs
{
    public class Tetromino
    {
        public int X;
        public int Y { get; set; }
        public int Orientation { get; set; }
        public ConsoleColor Color { get; set; }
        public Brick[] tetrominoShape { get; set; }

        public int size { get; set; }

        public Tetromino(Brick[] tetrominoShape, int x, int y, int orientation, ConsoleColor color)
        {
            this.tetrominoShape = tetrominoShape;
            this.X = x;
            this.Y = y;
            this.Orientation = orientation;
            this.Color = color;
            this.size = tetrominoShape.Length;
        }

        public Tetromino()
        {
        }

        public virtual void CreateBrick(Brick[] tetrominoShape,int x, int y, int orientation)
        {
        }
    }
    }
