using System;
using System.Linq;
using System.Collections.Generic;

namespace Snake_Moves
{
    class Program
    {
        public static object Stack { get; private set; }

        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[] snake = Console.ReadLine().ToCharArray();


            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            Queue<char> snakeBody = new Queue<char>();
            for (int i = 0; i < snake.Length; i++)
            {
                snakeBody.Enqueue(snake[i]);
            }
            bool leftOrRight = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (leftOrRight == false)
                {

                    for (int k = 0; k < matrix.GetLength(1); k++)
                    {
                        char tail = snakeBody.Dequeue();
                        matrix[i, k] = tail;
                        snakeBody.Enqueue(tail);
                    }
                    leftOrRight = true;
                }
                else if (leftOrRight == true)
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        char tail = snakeBody.Dequeue();
                        matrix[i, j] = tail;
                        snakeBody.Enqueue(tail);
                    }
                    leftOrRight = false;
                }

                
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    Console.Write($"{matrix[i, k]}");
                }
                if (i < matrix.GetLength(0) - 1)
                {

                    Console.WriteLine();
                }
            }
        }
    }
}
