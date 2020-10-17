using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson5
{
    public class Queue
    {
        public static Queue<Brick[]> myQ = new Queue<Brick[]>();
        public static void addElement(Brick[] brick)
        {
            
            myQ.Enqueue(brick);
        }

        public Queue()
        {
            myQ = new Queue<Brick[]>();
        }
        public void Print(ConsoleColor Fill)
        {
            Brick[] kostka = new Brick[4];
            kostka = myQ.Dequeue();
                for (int j = 0; j < kostka.Length; j++)
                {
                    Console.ForegroundColor = Fill;
                    char sign = '\u2588';
                    Console.SetCursorPosition(kostka[j].X, kostka[j].Y);
                    Console.Write(sign);
                }
        }
    }
}

