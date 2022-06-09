using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            var shopsProductsInfo = new Dictionary<string,Dictionary<string,double>>();
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string marketName = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (shopsProductsInfo.ContainsKey(marketName) == false)
                {
                    shopsProductsInfo.Add(marketName, new Dictionary<string, double>());
                }

                if (shopsProductsInfo[marketName].ContainsKey(product) == false)
                {
                    shopsProductsInfo[marketName].Add(product, new double());
                }

                shopsProductsInfo[marketName][product] = price;
            }
            foreach (var item in shopsProductsInfo.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
