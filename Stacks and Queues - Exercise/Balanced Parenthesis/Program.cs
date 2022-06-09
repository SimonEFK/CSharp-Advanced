using System;
using System.Collections.Generic;
using System.Linq;


namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openBrackets = new Stack<char>();
            string[] completeBrackets = { "[]", "{}", "()" };
            bool isBalanced = true;
            foreach (char item in input)
            {



                if (item == '(' || item == '[' || item == '{')
                {
                    openBrackets.Push(item);
                }
                else
                {
                    if (openBrackets.Count<=0)
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                    string currentElement = openBrackets.Peek() + item.ToString();
                    if (completeBrackets.Contains(currentElement))
                    {

                        openBrackets.Pop();
                    }
                    else
                    {
                        Console.WriteLine($"NO");
                        return;
                    }
                }
            }
            
            

                Console.WriteLine($"YES");
            
            
        }
    }
}
