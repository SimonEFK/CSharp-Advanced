using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Permutations_without_Repetition_optimised_
{
    internal class Program
    {
        private static string[] input;
        private static int totalPermutations;
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.Write("Generate all permutations with(swap): ");
            input = Console.ReadLine().Split(' ');

            PrintAllPermutations(0);

            Console.WriteLine("Total permutations: {0}", totalPermutations);

            Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");
            stopwatch.Reset();
        }

        private static void PrintAllPermutations(int index)
        {
            if (index >= input.Length)
            {
                Console.WriteLine(string.Join(" ", input));
                totalPermutations++;
                return;
            }

            PrintAllPermutations(index + 1);

            for (int i = index + 1; i < input.Length; i++)
            {
                Swap(index, i);
                PrintAllPermutations(index + 1);
                Swap(index, i);
            }
        }

        private static void Swap(int firstElementIndex, int secondElementIndex)
        {
            var temp = input[firstElementIndex];
            input[firstElementIndex] = input[secondElementIndex];
            input[secondElementIndex] = temp;

        }
    }
}
