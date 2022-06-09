using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            FillMatrix(matrix);

            string[] bombCoordinates = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                //.Select(int.Parse)
                .ToArray();


            for (int i = 0; i < bombCoordinates.Length; i++)
            {
                int[] bombLocation = bombCoordinates[i].Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bombRow = bombLocation[0];
                int bombCol = bombLocation[1];
                int currentDamage = matrix[bombRow, bombCol];
                if (currentDamage<=0)
                {
                    continue;
                }
                matrix[bombRow, bombCol] = 0;

                if (InRange(matrix, bombRow - 1, bombCol - 1) && matrix[bombRow - 1, bombCol - 1] > 0)
                {
                    matrix[bombRow - 1, bombCol - 1] -= currentDamage;
                }
                if (InRange(matrix, bombRow - 1, bombCol) && matrix[bombRow - 1, bombCol] > 0)
                {
                    matrix[bombRow - 1, bombCol] -= currentDamage;
                }
                if (InRange(matrix, bombRow - 1, bombCol + 1) && matrix[bombRow - 1, bombCol + 1] > 0)
                {
                    matrix[bombRow - 1, bombCol + 1] -= currentDamage;
                }

                if (InRange(matrix, bombRow, bombCol - 1) && matrix[bombRow, bombCol - 1] > 0)
                {
                    matrix[bombRow, bombCol - 1] -= currentDamage;
                }
                if (InRange(matrix, bombRow, bombCol + 1) && matrix[bombRow, bombCol + 1] > 0)
                {
                    matrix[bombRow, bombCol + 1] -= currentDamage;
                }

                if (InRange(matrix, bombRow + 1, bombCol - 1) && matrix[bombRow + 1, bombCol - 1] > 0)
                {
                    matrix[bombRow + 1, bombCol - 1] -= currentDamage;
                }
                if (InRange(matrix, bombRow + 1, bombCol) && matrix[bombRow + 1, bombCol] > 0)
                {
                    matrix[bombRow + 1, bombCol] -= currentDamage;
                }
                if (InRange(matrix, bombRow + 1, bombCol + 1) && matrix[bombRow + 1, bombCol + 1] > 0)
                {
                    matrix[bombRow + 1, bombCol + 1] -= currentDamage;
                }




            }
            int count = 0;
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum} ");
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write($"{matrix[j, k]} ");
                }
                Console.WriteLine();
            }












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
        private static bool InRange(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }




    }

}
