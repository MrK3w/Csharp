using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace tetirs
{
    class Tblock : Tetromino
    {
        public Tblock(Brick[] tetrominoShape, int x, int y, int orientation, ConsoleColor color) : base(tetrominoShape, x, y, orientation, color)
        {
            CreateBrick(tetrominoShape,x, y,orientation);
            Color = color;
        }
        public override void CreateBrick(Brick[] tetrominoShape,int x, int y, int orientation)
        {
            tetrominoShape[0].PositionX = 1;
            tetrominoShape[0].PositionY = 0;
            tetrominoShape[1].PositionX = 0;
            tetrominoShape[1].PositionY = 1;
            tetrominoShape[2].PositionX = 1;
            tetrominoShape[2].PositionY = 1;
            tetrominoShape[3].PositionX = 2;
            tetrominoShape[3].PositionY = 1;
            for (int i = 0; i < tetrominoShape.Length; i++)
            {
                tetrominoShape[i].PositionX += x;
                tetrominoShape[i].PositionY += y;
            }
        }
    }
}