using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class Student : Person
    {
        
        public int RegistrationNumber { get; set; }

        public List<Exam> Exams { get; set; } = new List<Exam>();


        public Student(string name, string surname, int age, int regNumber) : base(name,surname, age)
        {
            RegistrationNumber = regNumber;
        }        

        public void Attend(Course course, DateTime datetime)
        {
            Courses.Add(course);
        }

        public void WriteExam(Course course, DateTime datetime)
        {
            var exam = new Exam(course, datetime);
            Exams.Add(exam);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
