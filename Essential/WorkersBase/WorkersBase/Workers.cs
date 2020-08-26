namespace WorkersBase
{
    class Workers
    {
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Workers(string name, string position, string salary, int experience)
        {
            Name = name;
            Position = position;
            Salary = salary;
            Experience = experience;
        }
    }
}
