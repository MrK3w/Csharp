using System;
using System.Linq;

namespace du2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(new string(Convert.ToString(a).Reverse().ToArray()));
            Console.WriteLine($"your input was: {a} reverse input is {b}");
        }
    }
}