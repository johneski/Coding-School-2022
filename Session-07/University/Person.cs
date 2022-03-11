using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Person
    {
        public List<Course>? Courses { get; set; }
        public Guid ID { get; }
        public int Age { get; }
        public virtual string Name { get; set; }

        public Person(string name, int age)
        {
            ID = Guid.NewGuid();
            Name = name;
            Age = age;
        }


    }
}
