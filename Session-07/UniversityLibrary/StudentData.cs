using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    [Serializable]
    public class StudentData : Person
    {
        
        public int RegistrationNumber { get; set; }

        public List<Exam> Exams { get; set; }


        public StudentData(string name, int age, int regNumber) : base(name, age)
        {
            RegistrationNumber = regNumber;
        }

    }
}
