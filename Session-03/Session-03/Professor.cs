using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Professor : Person

    {
        public string Rank { get; set; }
        public Course[] Courses;
        private readonly string[] RankList = {"full", "associate", "assistant"};
        public Professor(string name, ushort age, string rank, Course[] courses) : base(name, age)
        {
            Courses = courses;
            Rank = rank;      
        }
        
        public void Teach(Course course, DateTime datetime)
        {

        }

        
        public void SetGrade(Guid studentID, Guid courseID, Grade grade)
        {

        }

        public override string GetName()
        {
            return "Dr. " + Name;
        }
    }

    
}
