using System;

namespace du22
{
    class Program
    {
        static void Main(string[] args)
        {
            int poc = 0;
            string phrase = "The, auto is in The  THE train.";
            Console.Write("Write a word: ");
            string s = Console.ReadLine();
            string[] words = phrase.Split(' ',',','.');
            foreach (var word in words)
            {
               if (s.Equals(word, StringComparison.InvariantCultureIgnoreCase))
               {
                    poc++;
               }
            }
            System.Console.WriteLine($"Word {s} is there: {poc} times");
        }
    }
}
