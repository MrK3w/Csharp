using System;

namespace lesson5
{
    public static class BlockFactory
    {
        public static Tetromino Build(int i)
        {
            Random brick = new Random();
            int brickos = brick.Next(1, 8);
            switch (brickos)
            {
                case 1:
                    return new Line(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.Cyan);
                case 2:
                    return new Lbrick(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.White);
                case 3:
                    return new Square(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.Yellow);
                case 4:
                    return new Jbrick(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.DarkBlue);
                case 5:
                    return new Sblock(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.DarkGreen);
                case 6:
                    return new Tblock(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.Magenta);
                case 7:
                    return new Zblock(new Brick[4], 0, i * 3 + 1, 0, ConsoleColor.Red);
                default:
                    return new Tetromino();
            }
        }
    }
}
