using System;
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
            Queue fronta = new Queue();
            Brick[] kostka = new Brick[4];
            Brick[] kostka1 = new Brick[4];
            
            for (int i = 0; i < 4; i++)
            {
                kostka1[i].X = i + 1;
                kostka1[i].X = i + 5;
            }

            Tetromino kosticka = new Tetromino(1,3);
            kostka[0].X=  5;
            kostka[0].Y = 5;
            kostka[1].X = 5;
            kostka[1].Y = 6;
            kostka[2].X = 6;
            kostka[2].Y = 5;
            kostka[3].X = 6;
            kostka[3].Y = 6;
            Queue.addElement(kostka);
            Queue.addElement(kostka1);
            fronta.Print(ConsoleColor.DarkGreen);
            fronta.Print(ConsoleColor.DarkRed);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 10);
        }
    }
}
