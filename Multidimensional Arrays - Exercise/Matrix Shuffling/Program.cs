using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Matrix_Shuffling
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
            FillMatrix(matrix);
            string pattern = @"(?<![A-Za-z0-9])[s][w][a][p] ([0-9][0-9]* [0-9][0-9]* [0-9][0-9]* [0-9][0-9]*)(?![A-Za-z0-9])";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            var match = Regex.Match(input,pattern);
            while (input != "END")
            {

                if (match.Success)
                {
                    string[] info = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int[] elementOneCordinates = new int[] { int.Parse(info[1]), int.Parse(info[2]) };
                    int[] elementTwoCordinates = new int[] { int.Parse(info[3]), int.Parse(info[4]) };
                    if (IsElementOneValid(matrix, elementOneCordinates) && IsElementTwoValid(matrix, elementTwoCordinates))
                    {

                        string temp = matrix[elementOneCordinates[0], elementOneCordinates[1]];
                        matrix[elementOneCordinates[0], elementOneCordinates[1]] = matrix[elementTwoCordinates[0], elementTwoCordinates[1]];
                        matrix[elementTwoCordinates[0], elementTwoCordinates[1]] = temp;
                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        input = Console.ReadLine();
                        match = Regex.Match(input, pattern);
                        continue;

                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                        input = Console.ReadLine();
                        match = Regex.Match(input, pattern);
                        continue;
                    }


                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                    input = Console.ReadLine();
                    match = Regex.Match(input, pattern);
                    continue;
                }                
            }

        }

        private static bool IsElementOneValid(string[,] matrix, int[] elementOneCordinates)
        {

            if ((elementOneCordinates[0] > matrix.GetLength(0) || elementOneCordinates[0] < 0) || (elementOneCordinates[1] > matrix.GetLength(1) || elementOneCordinates[1] < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static bool IsElementTwoValid(string[,] matrix, int[] elementTwoCordinates)
        {

            if ((elementTwoCordinates[0] > matrix.GetLength(0) || elementTwoCordinates[0] < 0) || (elementTwoCordinates[1] > matrix.GetLength(1) || elementTwoCordinates[1] < 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void FillMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] currentArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                //.Select(int.Parse)
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
