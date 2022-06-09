using System;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            matrix = FillMatrix(matrix);

            int secondDiagonalSum = GetSecondaryDiagonalSum(matrix);
            int diagonalSum = GetDiagonalSum(matrix);
            Console.WriteLine($"{Math.Abs(diagonalSum - secondDiagonalSum)}");

        }


        public static int[,] FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentArray = ReadInput();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentArray[j];
                }
            }
            return matrix;
        }
        public static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        }

        private static int GetSecondaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            int counter = 0;
            int count = Math.Max(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = count - 1; i >= 0; i--)
            {
                sum += matrix[counter++, i];

            }
            return sum;
        }
        private static int GetDiagonalSum(int[,] matrix)
        {
            int sum = 0;

            int count = Math.Max(matrix.GetLength(0), matrix.GetLength(1));
            for (int i = 0; i < count; i++)
            {
                sum += matrix[i, i];

            }
            return sum;
        }
    }
}
