using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class Student
    {
        public StudentData Data { get; set; }

        public Student(StudentData data)
        {
            Data = data;
        }

        public void Attend(Course course, DateTime datetime)
        {
            Data.Courses.Add(course);
        }

        public void WriteExam(Course course, DateTime datetime)
        {
            var exam = new Exam(course, datetime);
            Data.Exams.Add(exam);
        }
    }
}
