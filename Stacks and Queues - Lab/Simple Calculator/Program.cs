using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> intStack = new Stack<string>();
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            ReverseStack(intStack, input);
            int result = 0;

            while (intStack.Count > 1)
            {
                int numberAlpha = int.Parse(intStack.Pop());    
                string action = intStack.Pop();
                int numberBeta = int.Parse(intStack.Pop());
                if (action == "+")
                {
                    result = numberAlpha + numberBeta;
                }
                else
                {
                    result = numberAlpha - numberBeta;
                }
                intStack.Push(result.ToString());
            }
            Console.WriteLine($"{intStack.Pop()}");
        }

        private static void ReverseStack(Stack<string> intStack, string[] input)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                intStack.Push(input[i]);
            }
        }
    }
}
