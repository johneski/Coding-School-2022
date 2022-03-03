using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Grade
    {
        public Guid ID;
        public Guid StudentID;
        public Guid CourseID;
        public int Value;

        public Grade(Guid studentID, Guid courseID, int grade)
        {
            ID = Guid.NewGuid();
            StudentID = studentID;
            CourseID = courseID;
            Value = grade;
        }
    }
}
