using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesValue = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());

            Stack<int> stackOfClothes = new Stack<int>(clothesValue);

            int currValue = 0;
            int racks = 1;
            int count = stackOfClothes.Count;

            while (stackOfClothes.Count > 0)
            {



                currValue += stackOfClothes.Peek();
                if (currValue > rackCapacity)
                {
                    currValue = 0;
                    racks++;

                }
                else if (currValue <= rackCapacity)
                {                                        
                    stackOfClothes.Pop();
                }



            }
            Console.WriteLine($"{racks}");
        }
    }
}
