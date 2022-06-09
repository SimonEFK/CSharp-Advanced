using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                string currentName = Console.ReadLine();
                names.Add(currentName);
            }
            Console.WriteLine($"{string.Join(Environment.NewLine, names)}");
        }
    }
}
