using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        public List<Course> Courses { get; set; } = new List<Course>();
        public Guid ID { get; }
        public int Age { get; set; }
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }

        public virtual string Fullname { get => $"{Name} {Surname}"; }

        public Person(string name, string surname, int age)
        {
            ID = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Age = age;
        }


    }
}
