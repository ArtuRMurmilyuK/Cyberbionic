namespace ServisApp
{
    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int Course { get; set; }

        public string Specialty { get; set; }

        public Student(string name, int age, int course, string specialty)
        {
            Name = name;
            Age = age;
            Course = course;
            Specialty = specialty;
        }
    }
}