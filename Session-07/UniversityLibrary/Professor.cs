using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class Professor
    {
        public ProfessorData Data { get; set; }

        public Professor(ProfessorData data)
        {
            Data = data;
        }

        
        public void Teach(Course course)
        {
            Data.Courses.Add(course);
        }

        public Grade SetGrade(Guid courseID, Guid studentID, int value)
        {
            var grade = new Grade(courseID, studentID, value);
            Data.Grades.Add(grade);

            return grade;
        }

        public string GetName()
        {
            return Data.Name;
        }

        public bool TeachesCourse(Course course)
        {
            foreach(Course c in Data.Courses)
            {
                if(c.Code == course.Code)
                    return true;
            }

            return false;
        }
        
    }
}
