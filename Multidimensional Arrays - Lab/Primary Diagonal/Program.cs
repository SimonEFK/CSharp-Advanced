using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentArrey = ReadInput();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currentArrey[k];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine($"{sum}");

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
