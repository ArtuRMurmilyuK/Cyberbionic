using System;

namespace T3
{
    public class Manager : IManager
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public void Job()
        {
            Console.WriteLine("collection of products");
        }

        public void GiveAnAssignment()
        {
            Console.WriteLine("task given");
        }
    }
}