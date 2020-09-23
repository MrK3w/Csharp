using System;

namespace du22
{
    class Program
    {
        static void Main(string[] args)
        {
            int poc = 0;
            string phrase = "The, auto is in The train.";
            phrase = phrase.ToUpper();
            Console.Write("Write a word: ");
            string s = Console.ReadLine();
            s = s.ToUpper();
            string[] words = phrase.Split(' ',',','.');
            foreach (var word in words)
            {
                if (s == word)
                {
                    poc++;
                }
            }
            System.Console.WriteLine($"Word {s} is there: {poc} times");
        }
    }
}
