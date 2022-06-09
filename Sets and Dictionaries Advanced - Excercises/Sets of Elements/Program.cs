using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> n = new HashSet<int>();
            HashSet<int> m = new HashSet<int>();
            for (int i = 0; i < count[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                n.Add(number);

            }

            for (int i = 0; i < count[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                m.Add(number);
            }

            n.IntersectWith(m);
            Console.WriteLine($"{string.Join(' ', n)}");


        }
    }
}
