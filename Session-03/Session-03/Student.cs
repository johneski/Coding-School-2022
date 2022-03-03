using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Student : Person
    {
        public int RegistrationNumber;
        public Course[] Courses;

        public Student(string name, ushort age, int registrationNumber, Course[] courses) : base(name, age)
        {
            RegistrationNumber = registrationNumber;
            Courses = courses;
        }

        public void Attend(Course course, DateTime datetime)
        {

        }

        public void WriteExam(Course course, DateTime datetime)
        {

        }


    }
}
