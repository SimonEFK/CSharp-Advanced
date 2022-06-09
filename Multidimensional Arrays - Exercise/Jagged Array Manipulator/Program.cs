using System;
using System.Linq;
using System.Collections.Generic;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[count][];
            for (int i = 0; i < count; i++)
            {
                double[] tempArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                jaggedArray[i] = tempArray;
            }
            int counter = 0;

            for (int i = 0; i < count - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    for (int k = 0; k < jaggedArray[i].Length; k++)
                    {
                        jaggedArray[i][k] *= 2;
                        jaggedArray[i + 1][k] *= 2;
                    }
                    
                }
                else
                {
                    for (int k = 0; k < jaggedArray[i].Length; k++)
                    {
                        jaggedArray[i][k] /= 2;
                    }
                    for (int k = 0; k < jaggedArray[i + 1].Length; k++)
                    {
                        jaggedArray[i + 1][k] /= 2;
                    }
                }
            }
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (input[0] != "End")
            {
                string action = input[0];
                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);
                if (row >= 0 && row < count && col >= 0 && col < jaggedArray[row].Length)
                {

                    if (action == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in jaggedArray)
            {
                Console.WriteLine($"{string.Join(" ", jaggedArray[counter++])}");
            }
        }
    }
}
