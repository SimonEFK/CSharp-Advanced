using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            SortedDictionary<int, int> elements = new SortedDictionary<int, int>();

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (elements.ContainsKey(number) == false)
                {
                    elements.Add(number, 0);
                }
                elements[number]++;


            }
            foreach (var n in elements.Where(x => x.Value % 2 == 0 && x.Value >= 1))
            {
                Console.WriteLine($"{n.Key}");
            }
        }
    }
}
