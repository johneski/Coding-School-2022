using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class Professor : Person
    {
        public string ProfRank { get; set; }
        public override string Fullname { get => $"Dr. {Name} {Surname}"; }

        public List<Grade> Grades { get; set; } = new List<Grade>();


        public Professor(string name, string surname, int age, string profRank) : base(name, surname, age)
        {
            ProfRank = profRank;
        }


        public void Teach(Course course)
        {
            Courses.Add(course);
        }

        public Grade SetGrade(Guid courseID, Guid studentID, int value)
        {
            var grade = new Grade(courseID, studentID, value);
            Grades.Add(grade);

            return grade;
        }

        public string GetName()
        {
            return Name;
        }

        public bool TeachesCourse(Course course)
        {
            foreach(Course c in Courses)
            {
                if(c.Code == course.Code)
                    return true;
            }

            return false;
        }
        
    }
}
