namespace University
{
    public class ProfessorData : Person
    {
        public Rank ProfRank { get; set; }
        
        public override string Name { get => "Dr. " + Name; set => Name = value; }

        public List<Course> Courses { get; set; }

        public List<Grade> Grades { get; set; }
        

        public ProfessorData(string name, int age, Rank rank) : base(name, age)
        {
            ProfRank = rank;
        }

    }

}
