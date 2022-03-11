﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Institute
    {
        public string Name { get; set; }
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
