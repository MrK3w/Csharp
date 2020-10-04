using System;
using System.Text;

namespace homework
{
    class Program
    {
        //function to generate random letter of string
        private static char Letter()
        {
            Random rnd = new Random();
            char[] input = new char[] { 'A', 'G', 'T', 'B' };
            int k = rnd.Next(0, 4);
            return input[k];
        }

        //generate all strings
        private static void GeneratePopulation(string[] population, int stringLenght)
        {
            //lines of strings
            for (int i = 0; i < population.Length; i++)
            {
                StringBuilder sb = new StringBuilder();

                //characters in string
                for (int j = 0; j < stringLenght; j++)
                {
                   
                    sb.Append(Letter() + " ");
                }
                population[i] = sb.ToString();
            }
        }

        //calculate strength of string(occurrence's of A)
        private static int Fitness(string fit)
        {
            int poc = 0;
            char[] occur = fit.ToCharArray();
            for (int i = 0; i < fit.Length; i++)
            {
                if (occur[i] == 'A') poc++;
            }
            return poc;
        }
        //check if string exists with the selected power
        //return false if none string was found
        private static bool StringExist(string[] population,int quality)
        {
            int poc = 0;
            for (int i = 0; i < population.Length; i++)
            {
                if (quality <= Fitness(population[i]))
                {
                    poc++;
                }
            }
            if (poc == 0)
            {
                return false;
            }

            return true;
        }

        private static string Selection(string[] population, int quality)
        {
            Random rnd = new Random();
            int k = 0;
            bool check = false;
            //call function for checking if there exists string with that power
            //if no string was found exit program
            if (StringExist(population, quality) == false)
            {
                Console.WriteLine("There is no string with that power!");
                Environment.Exit(1);
            }
            //random generate element of array until, until element comply conditions
            while (check != true)
            {
                k = rnd.Next(0, population.Length);
                if (quality <= Fitness(population[k])) check = true;
            }
            return population[k];
        }

        //function generate random element, no requirements
        private static string Selection(string[] population)
        {
            Random rnd = new Random();
            var k = rnd.Next(0, population.Length);
            return population[k];
        }

        //Print all strings
        private static void PrintAll(string[] population)
        {
            for (int i = 0; i < population.Length; i++)
            {
                Console.WriteLine($"{i+1,2}. {population[i]}");
            }
            Console.WriteLine("______________________________________________\n\n");
        }

        //method for random crossing parents elements
        private static string Crossover(string father, string mother)
        {
            Random gen = new Random();
            StringBuilder cross = new StringBuilder();
            for (int i = 0; i < father.Length; i++)
            {
                int pom = gen.Next(1, 3);
                //switch choose from mothers or mothers gens
                switch (pom)
                {
                    case 1: cross.Append(father[i]);
                        break;
                    case 2: cross.Append(mother[i]);
                        break;
                }
            }
            var child = cross.ToString();
            return child;
        }
        //mutation has 50% chance to randomly switch element
        private static string Mutation(string child)
        {
            //remove all whitespaces from string
            child = child.Replace(" ", String.Empty);

            char[] mut = child.ToCharArray();
            Random gen = new Random();
            StringBuilder evolved = new StringBuilder();
            for (int i = 0; i < child.Length; i++)
            {
                //probability 0 copy element, 1 switches
                int probability = gen.Next(0, 2);
                if (probability == 0) evolved.Append(mut[i] + " ");
                else if (probability == 1) { evolved.Append(Letter() + " "); }
            }
            child = evolved.ToString();
            return child;
        }

        static void Main()
        {
            int pSize = 20;
            int dim = 10;
            string[] population = new string[pSize];
            //generate strings
            GeneratePopulation(population, dim);
            //print all strings
            PrintAll(population);

            string father = Selection(population, 3);
            string mother = Selection(population);
            string child = Mutation(Crossover(father, mother));

            Console.WriteLine($"string father is {father} and his strength is {Fitness(father)}");
            Console.WriteLine($"string mother is {mother} and his strength is {Fitness(mother)}");
            Console.WriteLine($"string child is {child} and his strength is {Fitness(child)}");
        }
    }
}
