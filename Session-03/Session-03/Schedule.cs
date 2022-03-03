using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Schedule
    {
        public Guid ID;
        public Guid CourseID;
        public Guid ProfessorID;
        public DateTime Callendar;

        public Schedule(Guid courseID, Guid profID, DateTime datetime)
        {
            ID = Guid.NewGuid();
            CourseID = courseID;
            ProfessorID = profID;
            Callendar = datetime;
        }
    }
}
