using System;
using System.Linq;

namespace Square_with_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = ReadInput();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            FillMatrix(matrix);

            int maxSum = int.MinValue;
            int[,] squareElements = new int[1, 1];

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int currMaxSum = int.MinValue;

                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    currMaxSum = GetSquareSum(matrix, i, k);
                    if (currMaxSum > maxSum)
                    {
                        maxSum = currMaxSum;
                        squareElements = MaxSquareElements(matrix, i, k);

                    }
                }
            }
            for (int i = 0; i < squareElements.GetLength(0); i++)
            {
                for (int k = 0; k < squareElements.GetLength(1); k++)
                {
                    Console.Write($"{squareElements[i, k]+" "}");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{maxSum}");
        }

        private static int[,] MaxSquareElements(int[,] matrix, int i, int k)
        {
            int[,] maxSquareElements =
            {
                            {matrix[i, k], matrix[i, k + 1]},
                            {matrix[i + 1, k],matrix[i + 1, k + 1] }
            };
            return maxSquareElements;
        }

        private static int GetSquareSum(int[,] matrix, int i, int k)
        {
            return matrix[i, k] + matrix[i, k + 1] + matrix[i + 1, k] + matrix[i + 1, k + 1];
        }

        private static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentArrey = ReadInput();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currentArrey[k];
                }
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
