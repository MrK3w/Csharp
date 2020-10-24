using System;
using System.Collections;
using System.Collections.Generic;

namespace tetirs
{
    public struct Brick
    {
        public int PositionX;
        public int PositionY;
    }
    class Program
    {
        const int CAPACITY = 10;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Queue SetOfBricks = new Queue(CAPACITY);
            Tetromino[] tetromina = new Tetromino[CAPACITY];
            for (int i = 0; i < CAPACITY; i++)
            {
                tetromina[i] = BlockFactory.Build(i);
                SetOfBricks.Enqueue(tetromina[i]);
            }
            SetOfBricks.Print();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 35);
        }
    }
}