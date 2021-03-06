﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tetirs
{
    class Square : Tetromino
    {
        public Square(Brick[] tetrominoShape, int x, int y, int orientation, ConsoleColor color) : base(tetrominoShape,x, y, orientation, color)
        {
            CreateBrick(tetrominoShape,x, y,orientation);
            Color = color;
        }
        /// <summary>
        /// creating Square tetromino
        /// </summary>
        /// <param name="tetrominoShape"> empty structure of Brick[]</param>
        /// <param name="x">X position of brick</param>
        /// <param name="y">Y position of brick</param>
        /// <param name="orientation">orientation of brick</param>
        public override void CreateBrick(Brick[] tetrominoShape, int x, int y,int orientation)
        {
            tetrominoShape[0].PositionX = 0;
            tetrominoShape[0].PositionY = 0;
            tetrominoShape[1].PositionX = 0;
            tetrominoShape[1].PositionY = 1;
            tetrominoShape[2].PositionX = 1;
            tetrominoShape[2].PositionY = 0;
            tetrominoShape[3].PositionX = 1;
            tetrominoShape[3].PositionY = 1;
            for (int i = 0; i < tetrominoShape.Length; i++)
            {
                tetrominoShape[i].PositionX += x;
                tetrominoShape[i].PositionY += y;
            }
        }
    }
}

