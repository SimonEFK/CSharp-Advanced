using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            var vloggers = new Dictionary<string, Dictionary<string, HashSet<string>>>();
            string followed = "followed";
            string followers = "followers";
            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] elements = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input.Contains("V-Logger"))
                {
                    string newVlogger = elements[0];
                    if (vloggers.ContainsKey(newVlogger) == false)
                    {
                        vloggers.Add(newVlogger, new Dictionary<string, HashSet<string>>());
                        vloggers[newVlogger].Add(followed, new HashSet<string>());
                        vloggers[newVlogger].Add(followers, new HashSet<string>());
                    }
                }
                else
                {
                    string newFollower = elements[0];
                    string vlogger = elements[2];

                    if (vloggers.ContainsKey(vlogger) &&
                        vloggers.ContainsKey(newFollower) &&
                        vlogger != newFollower) //&&
                        //!vloggers[vlogger][followers].Contains(newFollower))
                    {
                        vloggers[vlogger][followers].Add(newFollower);
                        vloggers[newFollower][followed].Add(vlogger);
                    }


                }
            }                       
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");            
            int counter = 1;
            foreach (var item in vloggers
                .OrderByDescending(x => x.Value[followers].Count)
                .ThenBy(x => x.Value[followed].Count))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1. {item.Key} : {item.Value[followers].Count} followers, {item.Value[followed].Count} following");
                    foreach (var person in item.Value[followers].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {person}");
                    }
                }
                else
                {
                    Console.WriteLine($"{counter}. {item.Key} : {item.Value[followers].Count} followers, {item.Value[followed].Count} following");
                }
                counter++;


            }
        }
    }
}
