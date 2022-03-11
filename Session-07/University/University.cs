using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    internal class University
    {
        public UniversityData Info { get; set; }

        public University(string name, int yearsInService)
        {
            Info = new UniversityData(name, yearsInService);
        }

        public string GetName()
        {
            return Info.Name;
        }

        public void SetName(string name)
        {
            Info.Name = name;
        }

        public Student CreateStudent(string name, int age, int registrationNumber)
        {
            var studentData = new StudentData(name, age, registrationNumber);
            var student = new Student(studentData);
            Info.Students.Add(student);

            return student;

        }

        public void DeleteStudent(Student student)
        {
            Info.Students.Remove(student);
        }

        public Professor CreateProfessor(string name, int age, Rank rank)
        {
            var profData = new ProfessorData(name, age, rank);
            var professor = new Professor(profData);
            Info.Professors.Add(professor);

            return professor;
        }

        public void DeleteProfessor(Professor prof)
        {
            Info.Professors.Remove(prof);
        }

        public Course CreateCourse(string code, string subject)
        {
            var course = new Course(code, subject);
            Info.Courses.Add(course);

            return course;
        }

        public void DeleteCourse(Course course)
        {
            Info.Courses.Remove(course);
        }

        //TODO: check if professor teaches the course
        public void SetSchedule(Guid courseID, Guid profID, DateTime datetime)
        {
            var schedule = new Schedule(courseID, profID, datetime);
            Info.ScheduledCourses.Add(schedule);
        }

        public void DeleteSchedule(Schedule schedule)
        {
            Info.ScheduledCourses.Remove(schedule);
        }

        public List<Student> GetStudents()
        {
            return Info.Students;
        }

        public List<Grade> GetGrades()
        {
            Info.Grades.Clear();

            foreach (Professor prof in Info.Professors)
            {
                    prof.Info.Grades.ForEach(g => Info.Grades.Add(g));
            }

            return Info.Grades;
        }

        public List<Professor> GetProfessors()
        {
            return Info.Professors;
        }


    }
}
