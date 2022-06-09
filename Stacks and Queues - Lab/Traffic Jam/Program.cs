using System;
using System.Collections.Generic;
using System.Linq;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string input = string.Empty;
            Queue<string> stopLightQueue = new Queue<string>();
            int carsCount = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input.ToUpper() == "GREEN")
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (stopLightQueue.Count > 0)
                        {

                            Console.WriteLine($"{stopLightQueue.Dequeue()} passed!");
                            carsCount++;
                        }
                    }
                }
                else
                {
                    stopLightQueue.Enqueue(input);
                }
            }
            Console.WriteLine($"{carsCount} cars passed the crossroads.");
        }
    }
}
