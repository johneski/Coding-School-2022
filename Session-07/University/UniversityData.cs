using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class UniversityData : Institute
    {
        // TODO: Implement get/set methods
        public List<Course> Courses { get;  }
        public List<ProfessorData> Professors { get;  }
        public List<StudentData> Students { get; }
        public List<Grade> Grades { get; }
        public List<Schedule> ScheduledCourses { get; set; }


        public UniversityData(string name, int yearsInService) : base(name, yearsInService)
        {
            Courses = new List<Course>();
            Professors = new List<ProfessorData>();
            Students = new List<StudentData>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();
        }


    }
}
