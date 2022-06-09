using System;
using System.Collections.Generic;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {



        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[size[0], size[1]];
            int playerRow = 0;
            int playerCol = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                    if (matrix[i, j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            char[] movement = Console.ReadLine().ToCharArray();
            bool isOutOfField = false;
            bool isDead = false;
            foreach (var item in movement)
            {
                int rowStep = 0;
                int colStep = 0;


                switch (item)
                {
                    case 'U':
                        rowStep = -1;
                        colStep = 0;
                        break;
                    case 'L':
                        rowStep = 0;
                        colStep = -1;
                        break;
                    case 'R':
                        rowStep = 0;
                        colStep = 1;
                        break;
                    case 'D':
                        rowStep = 1;
                        colStep = 0;
                        break;
                    default:
                        break;
                }

                if (!(InRange(matrix, playerRow + rowStep, playerCol + colStep)))
                {
                    matrix[playerRow, playerCol] = '.';
                    isOutOfField = true;
                }
                else
                {
                    matrix[playerRow, playerCol] = '.';
                    playerRow += rowStep;
                    playerCol += colStep;

                    if (matrix[playerRow, playerCol] == 'B' || matrix[playerRow, playerCol] == 'b')
                    {
                        matrix[playerRow - rowStep, playerCol - colStep] = '.';
                        isDead = true;

                    }
                    else
                    {
                        matrix[playerRow, playerCol] = 'P';
                    }
                }

                isDead = BunnySpread(matrix, isDead);

                if (isOutOfField)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
                else if (isDead)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
            }

        }

        private static bool BunnySpread(char[,] matrix, bool isDead)
        {
            List<int[]> bunnyLocations = new List<int[]>();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    if (matrix[i, j] == 'B')
                    {
                        bunnyLocations.Add(new int[2] { i, j });
                    }


                }
            }
            for (int i = 0; i < bunnyLocations.Count; i++)
            {
                int bunnyRow = bunnyLocations[i][0];
                int bunnyCol = bunnyLocations[i][1];
                if (matrix[bunnyRow, bunnyCol] == 'B')
                {
                    //up
                    if (InRange(matrix, bunnyRow - 1, bunnyCol))
                    {
                        if (matrix[bunnyRow - 1, bunnyCol] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow - 1, bunnyCol] = 'B';
                    }
                    //left
                    if (InRange(matrix, bunnyRow, bunnyCol - 1))
                    {
                        if (matrix[bunnyRow, bunnyCol - 1] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow, bunnyCol - 1] = 'B';
                    }
                    //right
                    if (InRange(matrix, bunnyRow, bunnyCol + 1))
                    {
                        if (matrix[bunnyRow, bunnyCol + 1] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                    }
                    //down
                    if (InRange(matrix, bunnyRow + 1, bunnyCol))
                    {
                        if (matrix[bunnyRow + 1, bunnyCol] == 'P')
                        {
                            isDead = true;
                        }
                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 'b')
                    {
                        matrix[i, j] = 'B';
                    }
                }
            }
            return isDead;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static bool InRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }


    }
}
