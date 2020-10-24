using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace tetirs
{
    public class Queue
    {
        private int capacity;
        private Tetromino[] arr;
        private int size;
        /// <summary>
        /// creating new queue
        /// </summary>
        /// <param name="capacity">maximal capacity of queue</param>
        public Queue(int capacity)
        {
            this.capacity = capacity;
            this.size = 0;
            this.arr = new Tetromino[capacity];
        }
        /// <summary>
        /// Adding new Tetromino to queue
        /// </summary>
        /// <param name="brick"></param>
        public void Enqueue(Tetromino brick)
        {

            if (this.size > this.capacity) Console.WriteLineblock("Queue is full!");
            else
            {
                this.arr[size] = brick;
                this.size++;
            }
        }
        /// <summary>
        /// Dequeue a tetromino from queue
        /// </summary>
        public void Dequeue()
        {
            if (this.size == 0)
                Console.WriteLineblock("The Queue is empty");
            else
            {
                this.arr[size - 1] = null;
                this.size--;
            }
        }
        /// <summary>
        /// Printing all Tetromino
        /// </summary>
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
                    Console.SetCursorPosition(kosticka.tetrominoShape[j].PositionX, kosticka.tetrominoShape[j].PositionY);
                    Console.Write(sign);
                }
            }
        }
    }
}