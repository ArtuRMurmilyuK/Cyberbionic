using System;
using System.Collections.Generic;
using System.Linq;

namespace ServisApp
{
    class Servise 
    {
        List<Student> studentsList = new List<Student>();

        public void AddStudent(string name, int age, int course, string specialty)
        {
            studentsList.Add(new Student(name,age,course,specialty));
        }

        public void DisplayAll()
        {
            foreach (var i in studentsList)
            {
                Console.WriteLine($"{i.Name} - {i.Age} - {i.Course} - {i.Specialty}");
            }
        }

        public void DisplayAge(int more, int late)
        {
            var age = studentsList.Where(ageStudent => ageStudent.Age >more && ageStudent.Age < late);

            foreach (var i in age)
            {
                Console.WriteLine(i.Age);
            }
        }

        public void DisplayCourse(int courses, string spec)
        {
            var courseDisplay = studentsList.Where(course => course.Course == courses && course.Specialty == spec);

            foreach (var i in courseDisplay)
            {
                Console.WriteLine(i.Name);
            }
        }

        public void DeleteByName(string name)
        {
            var deleteName = studentsList.Where(nameDelete => nameDelete.Name == name).Select(x=>x).First();

            studentsList.Remove(deleteName);
        }
    }
}