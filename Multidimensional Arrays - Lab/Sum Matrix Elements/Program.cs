using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = ReadInput();
            int sum = 0;
            int[,] matrix = new int[input[0], input[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currArrey = ReadInput();

                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currArrey[k];
                }
                sum += currArrey.Sum();
            }
            Console.WriteLine($"{input[0]}\n{input[1]}\n{sum}");
        }

        public static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
