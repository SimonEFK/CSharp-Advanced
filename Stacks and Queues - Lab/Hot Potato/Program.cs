using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(Console.ReadLine());
            Queue<string> children = new Queue<string>(input);
            while (children.Count > 1)
            {
                
                for (int i = 1; i < count; i++)
                {
                    children.Enqueue(children.Dequeue());
                    
                }
                Console.WriteLine($"Removed {children.Dequeue()}");

            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
