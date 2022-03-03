using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class University : Institute
    {
        public Course[] Courses;
        public Student[] Students;
        public Grade[] Grades;
        public Schedule[] ScheduledCourses;
        


        public University(string name, int yearsInService) : base(name, yearsInService)
        {
            Courses = new Course[20];
            Students = new Student[30];
            ScheduledCourses = new Schedule[60];
            Grades = new Grade[100];
        }

        public Student[] GetStudents()
        {
            return Students;
        }

        public Course[] GetCourses()
        {
            return Courses;
        }

        public Grade[] GetGrades()
        {
            return Grades;
        }

        public void SetSchedule(Guid courseID, Guid professorID, DateTime datetime)
        {
            try
            {
                int index = ScheduledCourses.Count(s => s != null);
                Schedule schedule = new Schedule(courseID, professorID, datetime);
                ScheduledCourses[index] = schedule;
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("The schedule is full!");
            }
            
        }

    }
}
