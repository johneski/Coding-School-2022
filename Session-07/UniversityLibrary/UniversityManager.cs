using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace University
{
    public class UniversityManager
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

        public UniversityData Data { get; set; }

        public UniversityManager(string name, int yearsInService)
        {
            Data = new UniversityData(name, yearsInService);
        }

        public string GetName()
        {
            return Data.Name;
        }

        public void SetName(string name)
        {
            Data.Name = name;
        }

        public Student CreateStudent(string name, int age, int registrationNumber)
        {
            var studentData = new StudentData(name, age, registrationNumber);
            var student = new Student(studentData);
            Data.Students.Add(student);

            return student;

        }

        public void DeleteStudent(Student student)
        {
            Data.Students.Remove(student);
        }

        public Professor CreateProfessor(string name, int age, Rank rank)
        {
            var profData = new ProfessorData(name, age, rank);
            var professor = new Professor(profData);
            Data.Professors.Add(professor);

            return professor;
        }

        public void DeleteProfessor(Professor prof)
        {
            Data.Professors.Remove(prof);
        }

        public Course CreateCourse(string code, string subject)
        {
            var course = new Course(code, subject);
            Data.Courses.Add(course);

            return course;
        }

        public List<Course> GetCourses()
        {
            return Data.Courses;
        }

        public void DeleteCourse(Course course)
        {
            Data.Courses.Remove(course);
        }

        //TODO: check if professor teaches the course
        public void SetSchedule(Guid courseID, Guid profID, DateTime datetime)
        {
            var schedule = new Schedule(courseID, profID, datetime);
            Data.ScheduledCourses.Add(schedule);
        }

        public List<Schedule> GetSchedule()
        {
            return Data.ScheduledCourses;
        }

        public void DeleteSchedule(Schedule schedule)
        {
            Data.ScheduledCourses.Remove(schedule);
        }

        public List<Student> GetStudents()
        {
            return Data.Students;
        }

        public List<Grade> GetGrades()
        {
            Data.Grades.Clear();

            foreach (Professor prof in Data.Professors)
            {
                    prof.Data.Grades.ForEach(g => Data.Grades.Add(g));
            }

            return Data.Grades;
        }

        public List<Professor> GetProfessors()
        {
            return Data.Professors;
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
                Data.Professors = JsonSerializer.Deserialize<List<Professor>>(text);
            }
            catch (FileNotFoundException e) { }
                            
            
        }

        public void LoadStudents()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Students)]);
                Data.Students = JsonSerializer.Deserialize<List<Student>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void LoadCourses()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Courses)]);
                Data.Courses = JsonSerializer.Deserialize<List<Course>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void LoadGrades()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Grades)]);
                Data.Grades = JsonSerializer.Deserialize<List<Grade>>(text);
            }
            catch (FileNotFoundException e) { }
        }


        public void LoadSchedule()
        {
            try
            {
                string text = File.ReadAllText(_paths[((int)Paths.Schedule)]);
                Data.ScheduledCourses = JsonSerializer.Deserialize<List<Schedule>>(text);
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

        
    }
}
