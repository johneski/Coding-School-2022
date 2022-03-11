using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Grade
    {
        public Guid ID { get; }
        public Guid CourseID { get;  }
        public Guid StudentID { get; }
        public int Value { get;  }

        public Grade(Guid courseID, Guid studentID, int value)
        {
            ID = Guid.NewGuid();
            CourseID = courseID;
            StudentID = studentID;
            Value = value;
        }
    }
}
