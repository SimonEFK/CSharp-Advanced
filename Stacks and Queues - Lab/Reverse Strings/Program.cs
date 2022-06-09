using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stringStack = new Stack<char>();
            char[] input = Console.ReadLine().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                stringStack.Push(input[i]);
            }
            while (stringStack.Count > 0)
            {
                Console.Write($"{stringStack.Pop()}");
            }

        }
    }
}
