using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
        /// Creating new queue.
        /// </summary>
        /// <param name="capacity">Maximal capacity of queue.</param>
        public Queue(int capacity)
        {
            this.capacity = capacity;
            size = 0;
            arr = new Tetromino[capacity];
        }

        /// <summary>
        /// Adding new Tetromino to queue
        /// </summary>
        /// <param name="brick"></param>
        public void Enqueue(Tetromino brick)
        {

            if (this.size > this.capacity) Console.WriteLine("Queue is full!");
            else
            {
                this.arr[size] = brick;
                this.size++;
            }
        }

        /// <summary>
        /// Dequeue a tetromino from queue
        /// </summary>
        public Tetromino Dequeue()
        {
            if (this.size == 0)
                throw new ArgumentNullException("GG");

            
            Tetromino dequeuedTetromino = arr[size - 1];
            arr[size - 1] = null;
            size--;

            return dequeuedTetromino;
        }

        /// <summary>
        /// Printing all Tetromino
        /// </summary>
        public void Print()
        {
            while (size != 0)
            {
                Tetromino kosticka = Dequeue();
                
                for (int j = 0; j < kosticka.Size; j++)
                {
                    Console.ForegroundColor = kosticka.Color;
                  

                    int currentBrickX = kosticka.tetrominoShape[j].PositionX;
                    int currentBrickY = kosticka.tetrominoShape[j].PositionY;

                    Console.SetCursorPosition(currentBrickX, currentBrickY);
                    Console.Write(Constants.SIGN);
                }
            }
        }
    }
}