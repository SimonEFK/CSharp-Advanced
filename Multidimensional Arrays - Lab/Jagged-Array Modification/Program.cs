using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int colLenght = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[colLenght][];
            for (int i = 0; i < colLenght; i++)
            {
                int[] currentArray = ReadInput();
                jaggedArray[i] = currentArray;
            }

            string[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            int counter = 0;
            while (elements[0].ToUpper() != "END")
            {

                string command = elements[0];
                int colIndex = int.Parse(elements[1]);
                int rowIndex = int.Parse(elements[2]);

                if (colIndex < 0 || colIndex >= colLenght || rowIndex < 0 || rowIndex >= jaggedArray[counter].Length)
                {
                    Console.WriteLine($"Invalid coordinates");
                }
                else
                {
                    if (command.ToUpper()=="ADD")
                    {
                        jaggedArray[colIndex][rowIndex] += int.Parse(elements[3]);
                    }
                    else
                    {
                        jaggedArray[colIndex][rowIndex] -= int.Parse(elements[3]);
                    }
                }
                counter++;
















                elements = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"{string.Join(" ", jaggedArray[i])}");
            }

        }













        public static int[] ReadInput()
        {
            return Console.ReadLine()
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
