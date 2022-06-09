using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Permutations_without_Repetition
{
    internal class Program
    {
        private static string[] input;
        private static string[] permutations;
        private static bool[] usedSymbolsIndexes;
        private static int totalPermutations;
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.Write("Generate all permutations with: ");
            input = Console.ReadLine().Split(' ');
            permutations = new string[input.Length];
            usedSymbolsIndexes = new bool[input.Length];

            PrintAllPermutations(0);
            Console.WriteLine("Total permutations: {0}", totalPermutations);
            
            Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");
            stopwatch.Reset();
        }

        private static void PrintAllPermutations(int index)
        {
            if (index >= permutations.Length)
            {
                Console.WriteLine(string.Join(" ", permutations));
                totalPermutations++;
                return;
            }

            for (int i = 0; i < permutations.Length; i++)
            {
                if (usedSymbolsIndexes[i] == false)
                {
                    permutations[index] = input[i];
                    usedSymbolsIndexes[i] = true;
                    PrintAllPermutations(index + 1);
                    usedSymbolsIndexes[i] = false;

                }


            }
        }
    }
}
