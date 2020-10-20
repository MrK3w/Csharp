using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace lesson5
{
    public class Queue
    {
        private int capacity;
        private Tetromino[] arr;
        private int size;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            this.arr = new Tetromino[capacity];
        }

        public void Enqueue(Tetromino brick)
        {

            if (this.size > this.capacity) Console.WriteLine("Queue is full!");
            else
            {
                this.arr[size] = brick;
                this.size++;
            }
        }

        public void Dequeue()
        {
            if (this.size == 0)
                Console.WriteLine("The Queue is empty");
            else
            {
                this.arr[size - 1] = null;
                this.size--;
            }
        }

        public void Print()
        {
            while (size != 0)
            {
                Tetromino kosticka = new Tetromino();
                kosticka = arr[size - 1];
                Dequeue();
                for (int j = 0; j < kosticka.size; j++)
                {
                    Console.ForegroundColor = kosticka.Color;
                    char sign = '\u2588';
                    Console.SetCursorPosition(kosticka.Kostka[j].X, kosticka.Kostka[j].Y);
                    Console.Write(sign);
                }
            }
        }
    }
}