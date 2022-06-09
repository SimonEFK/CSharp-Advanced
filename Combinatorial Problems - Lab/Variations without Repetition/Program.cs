using System;
using System.Diagnostics;

namespace Variations_without_Repetition
{
    internal class Program
    {
        static string[] elements;
        static int k;
        static bool[] usedElements;
        static string[] variations;
        static int totalVariations;
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.Write("Generate all variations(without repetitions) with: ");
            elements = Console.ReadLine().Split(' ');
            Console.Write("Variations lenght: ");
            k = int.Parse(Console.ReadLine());

            usedElements = new bool[elements.Length];
            variations = new string[k];


            PrintVariations(0);
            Console.WriteLine("Total variations: {0}", totalVariations);
            Console.WriteLine($"Elapsed Time: {stopwatch.Elapsed}");
            stopwatch.Reset();
        }

        private static void PrintVariations(int index)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(' ', variations));
                totalVariations++;
                return;
            }



            for (int i = 0; i < elements.Length; i++)
            {

                if (usedElements[i] == false)
                {
                    usedElements[i] = true;
                    variations[index] = elements[i];
                    PrintVariations(index + 1);
                    usedElements[i] = false;

                }

            }

        }
    }
}
