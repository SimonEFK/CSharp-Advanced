using System;
using System.Linq;

namespace Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[matrixSize, matrixSize];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] currentArray = Console.ReadLine().ToCharArray();
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = currentArray[k];
                }
            }
            int counter = 0;
            while (true)
            {
                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int currentMaxAttacks = 0;
                        if (matrix[i, j] != 'K')
                        {
                            continue;
                        }
                        if (InRange(matrix, i - 2, j + 1) && matrix[i - 2, j + 1] == 'K')
                        {
                            currentMaxAttacks++;
                        }
                        if (InRange(matrix, i - 2, j - 1) && matrix[i - 2, j - 1] == 'K')
                        {
                            currentMaxAttacks++;
                        }

                        if (InRange(matrix, i - 1, j + 2) && matrix[i - 1, j + 2] == 'K')
                        {
                            currentMaxAttacks++;
                        }
                        if (InRange(matrix, i + 1, j + 2) && matrix[i + 1, j + 2] == 'K')
                        {
                            currentMaxAttacks++;
                        }

                        if (InRange(matrix, i + 2, j + 1) && matrix[i + 2, j + 1] == 'K')
                        {
                            currentMaxAttacks++;
                        }
                        if (InRange(matrix, i + 2, j - 1) && matrix[i + 2, j - 1] == 'K')
                        {
                            currentMaxAttacks++;
                        }

                        if (InRange(matrix, i - 1, j - 2) && matrix[i - 1, j - 2] == 'K')
                        {
                            currentMaxAttacks++;
                        }
                        if (InRange(matrix, i + 1, j - 2) && matrix[i + 1, j - 2] == 'K')
                        {
                            currentMaxAttacks++;
                        }




                        if (currentMaxAttacks > maxAttacks)
                        {
                            maxAttacks = currentMaxAttacks;
                            knightRow = i;
                            knightCol = j;
                        }

                    }
                }
                if (maxAttacks == 0)
                {
                    Console.WriteLine($"{counter}");
                    break;
                }
                else
                {
                    matrix[knightRow, knightCol] = '0';
                    counter++;
                }
            }
        }
        public static bool InRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
