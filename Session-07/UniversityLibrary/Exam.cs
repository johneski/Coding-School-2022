using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Exam
    {
        public Guid ID { get; set; }
        public Guid CourseID { get; set; }
        public string CourseSubject { get; set; }
        public DateTime Date { get; set; }

        public Exam(Course course, DateTime datetime)
        {
            ID = Guid.NewGuid();
            CourseID = course.ID;
            CourseSubject = course.Subject;
            Date = datetime;
        }
    }
}
