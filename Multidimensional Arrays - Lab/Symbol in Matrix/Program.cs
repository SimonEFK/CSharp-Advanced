using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            string[,] matrix = new string[matrixSize, matrixSize];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    matrix[i, k] = input[k].ToString();
                }
            }
            string element = Console.ReadLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i,k]==element)
                    {
                        Console.WriteLine($"({i}, {k})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{element} does not occur in the matrix");
        }
    }
}
