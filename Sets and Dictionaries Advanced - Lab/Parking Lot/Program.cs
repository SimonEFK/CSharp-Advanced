using System;
using System.Collections.Generic;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsLog = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0].ToUpper()=="IN")
                {
                    carsLog.Add(tokens[1]);
                }
                else
                {
                    carsLog.Remove(tokens[1]);
                }
            }
            if (carsLog.Count<=0)
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine($"{string.Join('\n',carsLog)}");
            }
        }
    }
}
