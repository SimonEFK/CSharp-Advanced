using System;
using System.Linq;

namespace Recursive_Array_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = SumArrayRecussvly(input, 0);
            Console.WriteLine(result);
        }

        private static int SumArrayRecussvly(int[] array , int index)
        {
            if (index==array.Length)
            {
                return 0;
            }
            int sum = array[index] + SumArrayRecussvly(array, index + 1);
            return sum;
        }
    }
}
