using System;
using System.Collections.Generic;
using System.Linq;
namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).ToArray();
           // Queue<int> queue = new Queue<int>(input.Where(x => x % 2 == 0));
            Console.Write($"{string.Join(", ", input)}");


        }
    }
}
