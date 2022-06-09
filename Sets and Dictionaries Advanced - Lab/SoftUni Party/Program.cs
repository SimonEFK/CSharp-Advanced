using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guestList = new HashSet<string>();
            HashSet<string> vipList = new HashSet<string>();
            Regex pattern = new Regex(@"(?<![A-Za-z0-9 ])[0-9][A-Za-z0-9]+(?![A-Za-z0-9 ])");

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "PARTY")
                {

                    Match match = pattern.Match(input);
                    if (match.Success)
                    {
                        vipList.Add(input);
                    }
                    else
                    {
                        guestList.Add(input);
                    }
                }
                else
                {
                    while ((input = Console.ReadLine()) != "END")
                    {
                        Match match = pattern.Match(input);
                        if (match.Success)
                        {
                            vipList.Remove(input);
                        }
                        else
                        {
                            guestList.Remove(input);
                        }
                    }
                    if (input == "END")
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"{vipList.Count + guestList.Count}");
            if (vipList.Count > 0)
            {
                Console.WriteLine($"{string.Join("\n", vipList)}");
            }
            if (guestList.Count > 0)
            {
                Console.WriteLine($"{string.Join("\n", guestList)}");

            }
        }
    }
}
