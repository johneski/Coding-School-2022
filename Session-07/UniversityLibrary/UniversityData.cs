using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class UniversityData : Institute
    {
        
        public List<Course> Courses { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }


        public UniversityData(string name, int yearsInService) : base(name, yearsInService)
        {
            Courses = new List<Course>();
            Professors = new List<Professor>();
            Students = new List<Student>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();
        }


    }
}
