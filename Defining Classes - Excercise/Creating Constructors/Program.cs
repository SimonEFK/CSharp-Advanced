using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person peter = new Person();
            Person george = new Person(18);
            Person jose = new Person("Jose", 43);
            
        }
    }
}
