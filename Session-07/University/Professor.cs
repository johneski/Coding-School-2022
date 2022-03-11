using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Professor
    {
        public ProfessorData Info { get; set; }

        public Professor(ProfessorData data)
        {
            Info = data;
        }

        
        public void Teach(Course course)
        {
            Info.Courses.Add(course);
        }

        public Grade SetGrade(Guid courseID, Guid studentID, int value)
        {
            var grade = new Grade(courseID, studentID, value);
            Info.Grades.Add(grade);

            return grade;
        }

        public string GetName()
        {
            return Info.Name;
        }
        
    }
}
