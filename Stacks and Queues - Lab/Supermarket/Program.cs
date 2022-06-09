using System;
using System.Collections.Generic;
using System.Linq;


namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> quaue = new Queue<string>();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                if (input!="Paid")
                {
                    quaue.Enqueue(input);
                }
                else
                {
                    for (int i = quaue.Count - 1; i >= 0; i--)
                    {
                        Console.WriteLine(quaue.Dequeue());
                    }
                }

            }
            Console.WriteLine($"{quaue.Count} people remaining.");
        }
    }
}
