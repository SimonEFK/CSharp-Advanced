using System;
using System.Collections.Generic;
using System.Linq;


namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string action = Console.ReadLine();
                if (action.Contains("Play"))
                {
                    songs.Dequeue();
                }
                else if (action.Contains("Add"))
                {
                    string songToAdd = action.Substring(4);

                    if (songs.Contains(songToAdd))
                    {
                        Console.WriteLine($"{songToAdd} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(songToAdd);
                    }
                }
                else
                {
                    Console.WriteLine($"{string.Join(", ", songs)}");
                }
            }
            Console.WriteLine($"No more songs!");

        }
    }
}
