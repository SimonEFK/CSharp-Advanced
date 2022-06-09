using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsArrey = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> cupsQuaue = new Queue<int>(cupsArrey);

            int[] bottlesArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Stack<int> bottlesStack = new Stack<int>(bottlesArray);
            int wastedWater = 0;
            bool capacityLeft = false;
            int leftOver = 0;
            while (cupsQuaue.Count > 0 && bottlesStack.Count > 0)
            {
                int currBottleValue = bottlesStack.Pop();
                int currCupCapacity = cupsQuaue.Peek();

                currCupCapacity -= currBottleValue;
                if (currCupCapacity <= 0)
                {
                    cupsQuaue.Dequeue();
                    wastedWater += Math.Abs(currCupCapacity);
                }
                else if (currCupCapacity > 0)
                {
                    while (currCupCapacity > 0)
                    {
                        currCupCapacity -= bottlesStack.Pop();
                    }
                    cupsQuaue.Dequeue();
                    wastedWater += Math.Abs(currCupCapacity);
                }

            }
            if (cupsQuaue.Count <= 0 && bottlesStack.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesStack)}\nWasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsQuaue)}\nWasted litters of water: {wastedWater}");
            }
        }
    }
}
