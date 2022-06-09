using System;
using System.Collections.Generic;
using System.Linq;
namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodAmount = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            Queue<int> queueOrders = new Queue<int>(orders);
            Console.WriteLine($"{orders.Max()}");
            while (queueOrders.Count>0)
            {
                if (queueOrders.Peek()<=foodAmount)
                {
                    int soldAmount  = queueOrders.Peek();
                    foodAmount -= soldAmount;
                    queueOrders.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queueOrders.Count<=0)
            {
                Console.Write($"Orders complete");
            }
            else
            {
                Console.Write($"Orders left: {string.Join(" ", queueOrders)}");
            }
        }
    }
}
