using System;

namespace T3
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public void Job()
        {
            Console.WriteLine("doing something");
        }
    }
}