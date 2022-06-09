using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] elements = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string color = elements[0];

                for (int j = 1; j < elements.Length; j++)
                {
                    if (wardrobe.ContainsKey(color) == false)
                    {
                        wardrobe.Add(color, new Dictionary<string, int>());
                    }
                    if (wardrobe[color].ContainsKey(elements[j]) == false)
                    {
                        wardrobe[color].Add(elements[j], 0);
                    }
                    wardrobe[color][elements[j]]++;
                }


            }
            string[] pieceNeeded = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string itemColor = pieceNeeded[0];
            string item = pieceNeeded[1];
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var product in color.Value)
                {
                    Console.Write($"* {product.Key} - {product.Value}");

                    if (color.Key == itemColor && product.Key == item)
                    {
                        Console.WriteLine(" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();

                    }
                }
            }
        }
    }
}
