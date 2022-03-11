using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Institute
    {
        public string Name { get => Name; set => Name = value; }
        public Guid ID { get; }
        public int YearsInService { get;}

        public Institute(string name, int yearsInService)
        {
            ID = Guid.NewGuid();
            Name = name;
            YearsInService = yearsInService;
        }
    }
}
