using System;
using System.Collections.Generic;

namespace Queens_Puzzle
{
    internal class Program
    {
        private static HashSet<int> attackedRows = new HashSet<int>();
        private static HashSet<int> attackedCols = new HashSet<int>();
        private static HashSet<int> attackedLDiagonal = new HashSet<int>();
        private static HashSet<int> attackedRDiagonal = new HashSet<int>();
        private static int count = 0;
        static void Main(string[] args)
        {

            Console.Write($"Map size: ");
            int rows = int.Parse(Console.ReadLine());
            int cols = rows;

            

            var map = new string[rows, cols];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = "- ";
                }
            }





            SolvePuzzleAlgorithm(0, map);
            Console.WriteLine($"Total:{count}");
            

        }

        private static void SolvePuzzleAlgorithm(int row, string[,] map)
        {
            if (row == map.GetLength(0))
            {
                PrintMap(map);
                count++;
                return;
            }


            for (int col = 0; col < map.GetLength(1); col++)
            {

                if (IsSafe(map, row, col) == true)
                {


                    map[row, col] = "* ";
                    attackedRows.Add(row);
                    attackedCols.Add(col);
                    attackedLDiagonal.Add(col - row);
                    attackedRDiagonal.Add(col + row);
                    SolvePuzzleAlgorithm(row + 1, map);

                    map[row, col] = "- ";
                    attackedRows.Remove(row);
                    attackedCols.Remove(col);
                    attackedLDiagonal.Remove(col - row);
                    attackedRDiagonal.Remove(col + row);
                }
            }



        }
        private static bool IsSafe(string[,] map, int row, int col)
        {
            if (attackedRows.Contains(row) == false &&
                attackedCols.Contains(col) == false &&
                attackedLDiagonal.Contains(col - row) == false &&
                attackedRDiagonal.Contains(col + row) == false)
            {
                return true;
            }
            return false;
        }
        private static void PrintMap(string[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
