using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Person
    {
        public Person(string firstName,int age )
        {
            FirstName = firstName;
            Age = age;
        }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
