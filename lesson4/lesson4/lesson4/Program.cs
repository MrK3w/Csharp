using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace lesson4
{
    class Program
    {
        public struct Point
        {
            public int X;
            public int Y;
            public bool check;
        }

        static float GetDistance(Point a, Point b)
        {
            return (float) Math.Sqrt((a.X - b.X) * (a.X - b.X)) + ((a.Y - b.Y) * (a.Y - b.Y));
        }

        static void Print(Point[] point, ConsoleColor Fill, int i, char sign)
        {
            Console.SetCursorPosition(point[i].X, point[i].Y);
            Console.ForegroundColor = Fill;
            Console.Write(sign);
        }

        static void Print(Point point, ConsoleColor Fill, char sign)
        {
            Console.SetCursorPosition(point.X, point.Y);
            Console.ForegroundColor = Fill;
            Console.Write(sign);
        }
        static void PrintArea(int x, int y, ConsoleColor Fill, char sign)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.ForegroundColor = Fill;
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
        }

        static void Centropoid(Point[] point,int len)
        {
            Point centropoidPoint = new Point();
            for (int i = 0; i < point.Length; i++)
            {
                centropoidPoint.X += point[i].X;
                centropoidPoint.Y += point[i].Y;
            }
            centropoidPoint.X = centropoidPoint.X/len;
            centropoidPoint.Y = centropoidPoint.Y /len ;
            Print(centropoidPoint,ConsoleColor.Yellow, '\u25A0');
        }
        static void GeneratePoints(Point[] point,int count)
        {
            Random Rand = new Random();
            for (int i = 0; i < count; i++)
            {
                int o = Rand.Next(1, 15);
                int o1 = Rand.Next(1, 15);
                point[i].X = o;
                point[i].Y = o1;
            }
        }
        static void GeneratePoints(Point point, int count)
        {
            Random Rand = new Random();
            for (int i = 0; i < count; i++)
            {
                int o = Rand.Next(1, 15);
                int o1 = Rand.Next(1, 15);
                point.X = o;
                point.Y = o1;
            }
        }
        static void FurtherstPoint(Point[] point, int len)
            {
                float max = GetDistance(point[0], point[0]);
                int one = 0;
                int two = 0;
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < len; j++)
                    {
                        if (max < GetDistance(point[i], point[j]))
                        {
                            max = GetDistance(point[i], point[j]);
                            one = i;
                            two = j;
                        }
                    }
                }
                point[one].check = true;
                point[two].check = true;
            }

        static void Bonus(Point[] point, char sign)
        {
            
            Point sranda = new Point();
            Point sranda1 = new Point();
            Random Rand = new Random();
            int o = Rand.Next(1, 15);
                int o1 = Rand.Next(1, 15);
                int o2 = Rand.Next(1, 15);
                int o3 = Rand.Next(1, 15);
                sranda.X = o;
                sranda.Y = o1;
                sranda1.X = o2;
                sranda1.Y = o3;
                Console.SetCursorPosition(sranda1.X, sranda1.Y);
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(sign);
                Console.SetCursorPosition(sranda.X, sranda.Y);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write(sign);
                for (int i = 0; i < point.Length; i++)
                { 
                    Print(point, GetDistance(point[i], sranda1) < GetDistance(point[i], sranda)? ConsoleColor.DarkBlue : ConsoleColor.DarkMagenta, i, '\u25A0');
                }

        }
        static void NearestPoint(Point[] point, int number)
        {
            Point Near = new Point();

            Random Rand = new Random();

                int o = Rand.Next(1, 15);
                int o1 = Rand.Next(1, 15);
                Near.X = o;
                Near.Y = o1;

            for (int i = 0; i < point.Length - 1; i++)
            {
                for (int j = 0; j < point.Length - i - 1; j++)
                {
                    if (GetDistance(Near, point[j + 1]) < GetDistance(Near, point[j]))
                    {
                        var tmp = point[j + 1];
                        point[j + 1] = point[j];
                        point[j] = tmp;
                    }
                }
            }
            Print(Near, ConsoleColor.Yellow, '\u25A0');
            for (int i = 0; i < number; i++)
                Print(point[i], ConsoleColor.DarkCyan, '\u25A0');

        }
        static void Main()
            {
                int len = 10;
                Point[] point = new Point[len];
                PrintArea(20, 20, ConsoleColor.DarkGray, '\u2588');
                GeneratePoints(point,len);
                Centropoid(point, 10);
            //Bonus(point, '\u25A0');
            //FurtherstPoint(point, len);
            for (int i = 0; i < point.Length; i++)
            {
                Print(point, ConsoleColor.DarkRed, i, '\u25A0');
            }
            for (int i = 0; i < point.Length; i++)
            {
                Print(point, point[i].check ? ConsoleColor.DarkGreen : ConsoleColor.DarkRed, i, '\u25A0');
            }
            //NearestPoint(point,4);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 20);
        }
        }
    }


