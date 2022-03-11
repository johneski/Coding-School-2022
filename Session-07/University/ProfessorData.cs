namespace University
{
    public class ProfessorData : Person
    {
        public Rank ProfRank { get; set; }
        
        public override string Name { get => "Dr. " + Name; set => Name = value; }

        public ProfessorData(string name, int age, Rank rank, List<Course> courses) : base(name, age)
        {
            ProfRank = rank;
            Courses = courses;
        }
    }

}
