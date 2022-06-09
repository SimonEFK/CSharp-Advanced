using System;

namespace Generating_0_1_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var array = new int[input];

            FindAllNVectors(0, array);



        }

        private static void FindAllNVectors(int index, int[] array)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join(string.Empty, array));
                return;
            }
            for (int i = 0; i < 2; i++)
            {
                array[index] = i;
                FindAllNVectors(index + 1, array);
            }
        }
    }
}
