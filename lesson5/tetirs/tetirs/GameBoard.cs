using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace tetirs
{
    class GameBoard
    {
        const int CAPACITY = 10;
        const int WIDTH = 10;
        const int HEIGHT = 10;

        List<Tetromino> Board = new List<Tetromino>();
        public GameBoard()
        {
          
        }

        public void Play()
        {
            PrintArea();
            Queue SetOfBricks = new Queue(CAPACITY);
            Board.Add(BlockFactory.Build(3-1,5-1));
            for (int j = 0; j < Board[0].Size; j++)
            {
                Console.ForegroundColor = Board[0].Color;


                int currentBrickX = Board[0].tetrominoShape[j].PositionX;
                int currentBrickY = Board[0].tetrominoShape[j].PositionY;

                Console.SetCursorPosition(currentBrickX, currentBrickY);
                Console.Write(Constants.SIGN);
            }
            Thread.Sleep(800);
            ClearBoard();
            Console.SetCursorPosition(0,0);
            PrintArea();
            Console.BackgroundColor = ConsoleColor.Black;
            Board[0].TranslatePosition(0,1);
            for (int j = 0; j < Board[0].Size; j++)
            {
                Console.ForegroundColor = Board[0].Color;
                int currentBrickX = Board[0].tetrominoShape[j].PositionX;
                int currentBrickY = Board[0].tetrominoShape[j].PositionY;

                Console.SetCursorPosition(currentBrickX, currentBrickY);
                Console.Write(Constants.SIGN);
            }
        }

        public void PrintArea()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(Constants.SIGN);
                }
                Console.WriteLine();
            }
            Point originBorderPoint = new Point(0, 0);

            Console.BackgroundColor = ConsoleColor.Red;
            for (int x = originBorderPoint.X; x <= originBorderPoint.X + WIDTH; x++)
            {
                for (int y = originBorderPoint.Y; y <= originBorderPoint.Y + HEIGHT; y++)
                {
                    if (x == originBorderPoint.X || x == originBorderPoint.X + WIDTH)
                    {
                        Console.SetCursorPosition(x, y);
                        Console.Write(" ");
                    }
                }
                Console.SetCursorPosition(x, originBorderPoint.Y);
                Console.Write(" ");
                Console.SetCursorPosition(x, originBorderPoint.Y + HEIGHT);
                Console.Write(" ");
                
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void ClearBoard()
        {
            Console.Clear();
        }
    }
}
