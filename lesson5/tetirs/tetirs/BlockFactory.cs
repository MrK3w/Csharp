using System;

namespace tetirs
{
    public static class BlockFactory
    {
        /// <summary>
        /// Factory Pattern for creating different tetrominoblocks
        /// </summary>
        /// <param name="position"> moving every brick lower than last</param>
        /// <returns>return new tetromino object</returns>
        public static Tetromino Build(int x,int y)
        {
            Random brick = new Random();
            int selectRandomBrick = brick.Next(1, 8);
            switch (selectRandomBrick)
            {
                case 1:
                    return new Lineblock(new Brick[4], x, y, 0, ConsoleColor.Cyan);
                case 2:
                    return new Lbrick(new Brick[4], x, y, 0, ConsoleColor.White);
                case 3:
                    return new Square(new Brick[4], x, y, 0, ConsoleColor.Yellow);
                case 4:
                    return new Jbrick(new Brick[4], x, y, 0, ConsoleColor.DarkBlue);
                case 5:
                    return new Sblock(new Brick[4], x, y, 0, ConsoleColor.DarkGreen);
                case 6:
                    return new Tblock(new Brick[4], x, y, 0, ConsoleColor.Magenta);
                case 7:
                    return new Zblock(new Brick[4], x,y, 0, ConsoleColor.Red);
            }
            return null;
        }
    }
}
