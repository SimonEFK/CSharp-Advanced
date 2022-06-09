using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Family family = new Family();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person currentPerson = new Person(input[0], int.Parse(input[1]));
                family.Members.Add(currentPerson);
            }
            Console.WriteLine($"{family.GetOldestMember().Name} {family.GetOldestMember().Age}");
            
        }
    }
}
