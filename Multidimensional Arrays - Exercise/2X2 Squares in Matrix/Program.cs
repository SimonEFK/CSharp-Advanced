using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            matrix = FillMatrix(matrix);

            int matchCounter = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1; k++)
                {
                    string reference = matrix[i, k];
                    string[] squareElements = new string[] { matrix[i, k], matrix[i, k + 1], matrix[i + 1, k], matrix[i + 1, k + 1] };
                    if (!(squareElements.Any(x => x != reference)))
                    {
                        matchCounter++;
                    }
                }



            }
            Console.WriteLine($"{matchCounter}");


        }















        public static string[,] FillMatrix(string[,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currentArray = ReadInput();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = currentArray[j];
                }
            }
            return matrix;
        }
        public static string[] ReadInput()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

        }
    }
}
