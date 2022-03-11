using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class University
    {
        public UniversityData Data { get; set; }

        public University(UniversityData data)
        {
            Data = data;
        }
    }
}
