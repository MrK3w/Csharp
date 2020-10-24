using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace tetirs
{
    public struct Brick
    {
        public int PositionX;
        public int PositionY;
    }
 
    class Program
    {
        private int i = 10;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            GameBoard board = new GameBoard();
            board.Play();
            /*board.ClearBoard();*/
            Console.SetCursorPosition(20,20);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}