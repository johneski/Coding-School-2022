using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Session_03
{
    internal class Institute
    {
        public string Name;
        public int YearsInService;
        public Guid ID;

        protected Institute(string name, int yearsInService)
        {
            Name = name;
            YearsInService = yearsInService;
            ID = Guid.NewGuid();
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}
