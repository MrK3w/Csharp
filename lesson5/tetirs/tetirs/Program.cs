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

    class Progam
    {
        static void Main(string[] args)
        {
            Random brick = new Random();
            const int capacity = 10;
            Console.BackgroundColor = ConsoleColor.Black;
            Queue fronta = new Queue(capacity);
            Tetromino[] Tetromina = new Tetromino[capacity];
            int poz = 0;
            for (int i = 0; i < capacity; i++)
            {
               int brickos = brick.Next(1, 8);
                switch(brickos)
                {
                    case 1: Tetromina[i] = new Line(new Brick[4], 0, i*3+1+poz, 1, ConsoleColor.Cyan);
                        poz += 2;
                        break;
                    case 2:
                        Tetromina[i] = new Lbrick(new Brick[4], 0, i * 3 + 1+poz, 0, ConsoleColor.White);
                        break;
                    case 3:
                        Tetromina[i] = new Square(new Brick[4], 0, i * 3 + 1+ poz, 0, ConsoleColor.Yellow);
                        break;
                    case 4:
                        Tetromina[i] = new Jbrick(new Brick[4], 0, i * 3 + 1+ poz, 0, ConsoleColor.DarkBlue);
                        break;
                    case 5:
                        Tetromina[i] = new Sblock(new Brick[4], 0, i * 3 + 1+ poz, 0, ConsoleColor.DarkGreen);
                        break;
                    case 6:
                        Tetromina[i] = new Tblock(new Brick[4], 0, i * 3 + 1+ poz, 0, ConsoleColor.Magenta);
                        break;
                    case 7:
                        Tetromina[i] = new Zblock(new Brick[4], 0, i * 3 + 1+ poz, 0, ConsoleColor.Red);
                        break;
                }

                fronta.Enqueue(Tetromina[i]);
            }
            fronta.Print();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 35);
        }
    }
}