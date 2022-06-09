using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static int playerRow;
        static int playerCol;
        static int coalCount;
        static char[,] matrix;
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] movement = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            matrix = new char[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];

                    if (matrix[i, j] == 's')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                    if (matrix[i, j] == 'c')
                    {
                        coalCount++;
                    }
                }
            }

            foreach (var item in movement)
            {
                switch (item)
                {
                    case "up":
                        Move(-1, 0);

                        break;
                    case "down":
                        Move(+1, 0);
                        break;
                    case "right":
                        Move(0, +1);
                        break;
                    case "left":
                        Move(0, -1);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"{coalCount} coals left. ({playerRow}, {playerCol})");



        }



        public static void Move(int row, int col)
        {
            if (InRange(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '*';
                playerRow += row;
                playerCol += col;
                if (matrix[playerRow, playerCol] == 'c')
                {
                    coalCount--;
                    matrix[playerRow, playerCol] = '*';
                    if (coalCount <= 0)
                    {
                        Console.WriteLine($"You collected all coals! ({playerRow}, {playerCol})");
                        Environment.Exit(0);
                    }
                }
                else if (matrix[playerRow, playerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({playerRow}, {playerCol})");
                    Environment.Exit(0);
                }
            }
        }

        public static bool InRange(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
