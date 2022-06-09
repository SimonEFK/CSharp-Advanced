using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.

            for (int i = 0; i < n; i++)
            {
                string[] input = (Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries));
                if (input[0] == "1")
                {

                    stack.Push(int.Parse(input[1]));




                }
                else if (input[0] == "2"&&stack.Count>0)
                {
                    stack.Pop();
                }
                else if (input[0] == "3" && stack.Count > 0)
                {
                    Console.WriteLine($"{stack.Max()}");
                }
                //4
                else
                {
                    if (stack.Count > 0)
                    {

                        Console.WriteLine($"{stack.Min()}");
                    }
                }
            }
            Console.WriteLine($"{string.Join(", ", stack)}");
        }
    }
}

