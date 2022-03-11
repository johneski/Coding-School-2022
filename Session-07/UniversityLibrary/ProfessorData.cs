namespace University
{
    [Serializable]
    public class ProfessorData : Person
    {
        public string ProfRank { get; set; }
        private string _name;
        public override string Name { get => "Dr. " + _name; set => _name = value; }

        public List<Course> Courses { get; set; }

        public List<Grade> Grades { get; set; }
        

        public ProfessorData(string name, int age, string profRank) : base(name, age)
        {
            ProfRank = profRank;
        }

    }

}
