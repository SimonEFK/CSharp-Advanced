using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int age) : this()
        {            
            Age = age;
        }
        public Person(string firstName,int age) : this(age)
        {
            Name = firstName;
            Age = age;
        }
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
