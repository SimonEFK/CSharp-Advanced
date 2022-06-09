using System;
using System.Collections.Generic;
using System.Linq;

namespace Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < count; i++)
            {
                string[] personDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);
                Person currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }
            foreach (var item in people.Where(x=>x.Age>30).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}
