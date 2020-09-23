using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = "";
            int year = 0;
            try
            {
                do
                {
                    Console.Write("Select a year: ");
                    p = Console.ReadLine();
                    year = Convert.ToInt32(p);
                
                } while (p.Length != 4);
            }
            catch
            {
                Console.WriteLine("Unexpected error");
                return;
            }
            LeapYear(year);
        }

        public static void LeapYear(int p)
        {
            int poc = 0;
            while ((p % 4 == 0 && (p % 100 != 0 || p % 400 == 0)) != true)
            {
                p++;
                poc++;
            }
            if (poc == 0) Console.WriteLine($"{p} is a leap year");
            else Console.WriteLine($"{poc} Years are remaining");
        }
    }
}