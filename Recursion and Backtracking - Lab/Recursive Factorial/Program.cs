using System;

namespace Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());            
            long sum = CalculateNFactorial(input);

            Console.WriteLine(sum);
        }

        private static long CalculateNFactorial(int v)
        {
            
            if (v==1)
            {
                return 1;
            }
            long sum = v * CalculateNFactorial(v - 1);

            return sum;
        }
    }
}
