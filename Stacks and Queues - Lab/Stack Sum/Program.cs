using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var item in input)
            {
                intStack.Push(item);
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                if (action == "add")
                {
                    int numberAlpha = int.Parse(tokens[1]);
                    int numberBeta = int.Parse(tokens[2]);
                    intStack.Push(numberAlpha);
                    intStack.Push(numberBeta);

                }
                else
                {
                    int count = int.Parse(tokens[1]);
                    if (count < intStack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            intStack.Pop();
                        }
                    }
                }














                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {intStack.Sum()}");
        }
    }
}
