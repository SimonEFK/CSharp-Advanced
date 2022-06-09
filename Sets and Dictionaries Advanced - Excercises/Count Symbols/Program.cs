using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbolsCount = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (symbolsCount.ContainsKey(item)==false)
                {
                    symbolsCount.Add(item, 0);
                }
                symbolsCount[item]++;
            }
            foreach (var symbol in symbolsCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
