using System;

namespace Recursive_Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            PrintDrawRecusively(input);
        }

        private static void PrintDrawRecusively(int v)
        {
            if (v<=0)
            {
                return ;
            }
            Console.WriteLine(new string('*', v));
            PrintDrawRecusively(v - 1);
            Console.WriteLine(new string('#', v));
            //PrintDrawRecusively(v - 1);
        }
    }
}
