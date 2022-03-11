using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Schedule
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public Guid ProfessorID { get; set; }
        public DateTime Callendar { get; set; }

        public Schedule(Guid course, Guid prof, DateTime callendar)
        {
            ID = Guid.NewGuid();
            CourseID = course;
            ProfessorID = prof;
            Callendar = callendar;
        }
    }
}
