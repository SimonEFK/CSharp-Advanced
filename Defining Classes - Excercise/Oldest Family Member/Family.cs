using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    class Family
    {
        public Family()
        {
            Members = new List<Person>();
        }

        public List<Person> Members { get; set; }
        public void AddMember(Person person)
        {
            Members.Add(person);
        }
        public Person GetOldestMember()
        {
             Person oldestMember = Members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestMember;
        }
    }
}
