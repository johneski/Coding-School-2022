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
    }
}
