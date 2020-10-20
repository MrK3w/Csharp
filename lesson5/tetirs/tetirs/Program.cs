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
            Console.BackgroundColor = ConsoleColor.Black;
            Brick[] kostka = new Brick[4];
            Brick[] kostka1 = new Brick[4];
            Brick[] kostka2 = new Brick[4];
            Brick[] kostka3 = new Brick[4];
            Brick[] kostka4 = new Brick[4];
            Brick[] kostka5 = new Brick[4];
            Brick[] kostka6 = new Brick[4];
            Queue fronta = new Queue(10);
            Line kosticka = new Line(kostka,0, 1, 0, ConsoleColor.Cyan);
            Lbrick kosticka1 = new Lbrick(kostka1,0, 3, 0, ConsoleColor.White);
            Square kosticka2= new Square(kostka2,0, 6, 0, ConsoleColor.Yellow);
            Jbrick kosticka3 = new Jbrick(kostka3,0, 9, 0, ConsoleColor.DarkBlue);
            Sblock kosticka4 = new Sblock(kostka4,0, 12, 0, ConsoleColor.DarkGreen);
            Tblock kosticka5 = new Tblock(kostka5,0, 15, 0, ConsoleColor.Magenta);
            Zblock kosticka6 = new Zblock(kostka6,0, 18, 0, ConsoleColor.Red);
            fronta.Enqueue(kosticka);
            fronta.Enqueue(kosticka1);
            fronta.Enqueue(kosticka2);
            fronta.Enqueue(kosticka3);
            fronta.Enqueue(kosticka4);
            fronta.Enqueue(kosticka5);
            fronta.Enqueue(kosticka6);
            fronta.Print();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 23);
        }
    }
}