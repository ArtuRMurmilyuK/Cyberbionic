using System;
using System.Text.Json;

namespace SerializerExample
{
    class Program
    {
        static void Main()
        {
            Person tom=new Person{Name = "Anton", Age = 21};
            string json = JsonSerializer.Serialize<Person>(tom);

            Console.WriteLine(json);

            Person restoredPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(restoredPerson.Name);
            Console.WriteLine(restoredPerson.Age);
        }
    }

    class Person 
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
