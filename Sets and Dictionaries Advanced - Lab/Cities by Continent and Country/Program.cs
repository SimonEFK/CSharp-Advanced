using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            var geographicLocations = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (geographicLocations.ContainsKey(continent) == false)
                {
                    geographicLocations.Add(continent, new Dictionary<string, List<string>>());
                }
                if (geographicLocations[continent].ContainsKey(country) == false)
                {
                    geographicLocations[continent].Add(country,new List<string>());
                }

                geographicLocations[continent][country].Add(city);
            }
            foreach (var continent in geographicLocations)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
