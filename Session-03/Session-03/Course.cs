using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Course
    {
        public Guid ID;
        public string Code;
        public string Subject;

        public Course(string code, string subject)
        {
            ID = Guid.NewGuid();
            Code = code;
            Subject = subject;
        }
    }

}
