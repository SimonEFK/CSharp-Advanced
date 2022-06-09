using System;
using System.Diagnostics;

namespace Combinations_with_Repetition
{
    internal class Program
    {
        static string[] elements;
        static int k;
        static string[] combinations;
        static int totalCombinations;
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.Write("Generate all combinations(with repetitions) with: ");
            elements = Console.ReadLine().Split(' ');
            Console.Write("Combinations lenght: ");
            k = int.Parse(Console.ReadLine());


            combinations = new string[k];


            PrintCombinations(0, 0);
            Console.WriteLine("Total combinations: {0}", totalCombinations);
            Console.WriteLine($"Elapsed time: {stopWatch.Elapsed}");
            stopWatch.Stop();
        }

        private static void PrintCombinations(int index, int startPosition)
        {
            if (index >= combinations.Length)
            {
                Console.WriteLine(string.Join(' ', combinations));
                totalCombinations++;
                return;
            }



            for (int i = startPosition; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                PrintCombinations(index + 1, i );
            }
        }
    }
}
