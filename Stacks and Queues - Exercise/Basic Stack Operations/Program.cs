using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //Push n elements
            int n = input[0];
            //pop s elements;
            int s = input[1];
            //Find x;
            int x = input[2];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stack.Push(elements[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(x))
            {
                Console.WriteLine($"{"true"}");
            }
            else
            {
                if (stack.Count<=0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine($"{stack.Min()}");
                }

            }

        }
    }
}
