using System;
using System.Collections.Generic;
using System.Linq;


namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<int[]> stations = new Queue<int[]>();
            for (int i = 0; i < count; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                stations.Enqueue(input);
            }


            int fuel = 0;
            int route = 0;

            while (true)
            {
                fuel = 0;
                foreach (var item in stations)
                {
                    int currentFuel = item[0];
                    int currentDistance = item[1];
                    fuel += currentFuel - currentDistance;
                    if (fuel < 0)
                    {
                        stations.Enqueue(stations.Dequeue());
                        route++;
                        break;
                    }
                }
                if (fuel >= 0)
                {
                    Console.WriteLine($"{route}");
                    return;

                }



            }







        }
    }
}
