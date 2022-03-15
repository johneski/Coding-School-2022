using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace University
{
    public class UniversityManager : Institute
    {
        private enum Paths
        {
            Professors,
            Students,
            Courses,
            Grades,
            Schedule
        }

        private List<string> _paths = new List<string>{
            "professors.json",
            "students.json",
            "courses.json",
            "grades.json",
            "schedule.json"
        };

        public List<Course> Courses { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Student> Students { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Schedule> ScheduledCourses { get; set; }


        public UniversityManager(string name, int yearsInService) : base(name, yearsInService)
        {
            Courses = new List<Course>();
            Professors = new List<Professor>();
            Students = new List<Student>();
            Grades = new List<Grade>();
            ScheduledCourses = new List<Schedule>();
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public Student CreateStudent(string name, string surname,  int age, int registrationNumber)
        {
            
            var student = new Student(name, surname, age, registrationNumber);
            Students.Add(student);

            return student;

        }

        public void DeleteStudent(Student student)
        {
            Students.Remove(student);
        }

        public Professor CreateProfessor(string name, string surname, int age, string rank)
        {
            
            var professor = new Professor(name, surname, age, rank);
            Professors.Add(professor);

            return professor;
        }

        public void DeleteProfessor(Professor prof)
        {
            Professors.Remove(prof);
        }

        public Course CreateCourse(string code, string subject)
        {
            var course = new Course(code, subject);
            Courses.Add(course);

            return course;
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }

        public void DeleteCourse(Course course)
        {
            Courses.Remove(course);
        }

        //TODO: check if professor teaches the course
        public void SetSchedule(Guid courseID, Guid profID, DateTime datetime)
        {
            var schedule = new Schedule(courseID, profID, datetime);
            ScheduledCourses.Add(schedule);
        }

        public List<Schedule> GetSchedule()
        {
            return ScheduledCourses;
        }

        public void DeleteSchedule(Schedule schedule)
        {
            ScheduledCourses.Remove(schedule);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public List<Grade> GetGrades()
        {
            Grades.Clear();

            foreach (Professor prof in Professors)
            {
                    prof.Grades.ForEach(g => Grades.Add(g));
            }

            return Grades;
        }

        public List<Professor> GetProfessors()
        {
            return Professors;
        }

        public void LoadAll()
        {
            LoadProfessors();
            LoadStudents();
            LoadCourses();
            LoadSchedule();
            LoadGrades();
        }

        public void LoadProfessors()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int) Paths.Professors)]);
                Professors = (List<Professor>) JsonSerializer.Deserialize<List<Professor>>(text);
            }
            catch (FileNotFoundException e) { }
                            
            
        }

        public void LoadStudents()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Students)]);
                Students = JsonSerializer.Deserialize<List<Student>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void LoadCourses()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Courses)]);
                Courses = JsonSerializer.Deserialize<List<Course>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void LoadGrades()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Grades)]);
                Grades = JsonSerializer.Deserialize<List<Grade>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void LoadSchedule()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Schedule)]);
                ScheduledCourses = JsonSerializer.Deserialize<List<Schedule>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void SaveAll()
        {
            
            SaveProfessors();
            SaveStudents();
            SaveCourses();
            SaveGrades();
            SaveSchedule();        

        }

        public void SaveProfessors()
        {
            string professors = JsonSerializer.Serialize(GetProfessors());
            File.WriteAllText(_paths[((int)Paths.Professors)], professors);
        }

        public void SaveStudents()
        {
            string students = JsonSerializer.Serialize(GetStudents());
            File.WriteAllText(_paths[((int)Paths.Students)], students);
        }

        public void SaveGrades()
        {
            string grades = JsonSerializer.Serialize(GetGrades());
            File.WriteAllText(_paths[((int)Paths.Grades)], grades);
        }


        public void SaveCourses()
        {
            string courses = JsonSerializer.Serialize(GetCourses());
            File.WriteAllText(_paths[((int)Paths.Courses)], courses);
        }

        public void SaveSchedule()
        {
            string schedule = JsonSerializer.Serialize(GetSchedule());
            File.WriteAllText(_paths[((int)Paths.Schedule)], schedule);
        }

        public void Delete(Professor professor)
        {
            Professors.Remove(professor);
        }
        
    }
}
