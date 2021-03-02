using System;

namespace T3
{
    class Foreman : IForeman
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public void Job()
        {
            Console.WriteLine("purchase of materials");
        }

        public void Check()
        {
            Console.WriteLine("workers checked");
        }
    }
}