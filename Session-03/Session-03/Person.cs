using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        public Guid ID { get;}
        public string  Name { get; set; }
        public ushort Age { get; }

        public Person(string name, ushort age)
        {
            ID = Guid.NewGuid();
            Name = name;
            Age = age;
        }

        public virtual string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
