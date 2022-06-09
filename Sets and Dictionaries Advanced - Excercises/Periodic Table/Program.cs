using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }
            Console.WriteLine($"{string.Join(' ', elements)}");
        }
    }
}
