using System;
using System.Collections;
using System.Collections.Generic;

namespace lesson5
{
    public struct Brick
    {
        public int X;
        public int Y;
    }
    class Program
    {
        const int CAPACITY = 10;
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Queue fronta = new Queue(CAPACITY);
            Tetromino[] tetromina = new Tetromino[CAPACITY];
            for (int i = 0; i < CAPACITY; i++)
            {
                tetromina[i] = BlockFactory.Build(i);
                fronta.Enqueue(tetromina[i]);
            }
            fronta.Print();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 35);
        }
    }
}