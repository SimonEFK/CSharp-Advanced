using System;
using System.Linq;

namespace Sum_Matrix_Columns
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
                int[] currentArrey = ReadInput();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currentArrey[k];

                }
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int k = 0; k < matrix.GetLength(0); k++)
                {                    
                    sum += matrix[k, i];
                }
                Console.WriteLine($"{sum}");
                sum = 0;
            }













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
