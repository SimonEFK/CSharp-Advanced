using System;
using System.Collections.Generic;
using System.Linq;


namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            string word = string.Empty;
            Stack<string> history = new Stack<string>();
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int action = int.Parse(input[0]);
                if (action == 1)
                {
                    string currString = input[1];
                    word += currString;
                    history.Push(word);
                }
                else if (action == 2)
                {
                    int index = int.Parse(input[1]);
                    word = word.Substring(0, word.Length - index);
                    history.Push(word);
                }
                else if (action == 3)
                {
                    int index = int.Parse(input[1]);


                    Console.WriteLine($"{word[index - 1]}");


                }
                else
                {
                    if (history.Count > 1)
                    {
                        history.Pop();
                        word = history.Peek();

                    }
                    else
                    {
                        history.Pop();
                        word = string.Empty;
                    }
                }
            }
        }
    }
}
