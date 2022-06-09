using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];
            FillMatrix(matrix);
            int maxSum = int.MinValue;
            int[] elementsPartOne = new int[3];
            int[] elementsPartTwo = new int[3];
            int[] elementsPartThree = new int[3];
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 2; k++)
                {
                    int[] squareElements = new int[] {
                        matrix[i, k],
                        matrix[i, k + 1],
                        matrix[i, k + 2],

                        matrix[i + 1, k],
                        matrix[i + 1, k + 1],
                        matrix[i + 1, k + 2],

                        matrix[i+2,k],
                        matrix[i+2,k+1],
                        matrix[i+2,k+2],


                    };
                    int sum = squareElements.Sum();
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        elementsPartOne = new int[] { matrix[i, k], matrix[i, k + 1], matrix[i, k + 2] };
                        elementsPartTwo = new int[] { matrix[i + 1, k], matrix[i + 1, k + 1], matrix[i + 1, k + 2] };
                        elementsPartThree = new int[] { matrix[i + 2, k], matrix[i + 2, k + 1], matrix[i + 2, k + 2] };
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}\n{string.Join(" ", elementsPartOne)}\n{string.Join(" ",elementsPartTwo)}\n{string.Join(" ",elementsPartThree)}");
        }




        public static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] currentArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentArray[j];
                }
            }
            //return matrix;
        }

    }
}
