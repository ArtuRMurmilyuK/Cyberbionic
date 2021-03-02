using System;

namespace T3
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public void Job()
        {
            Console.WriteLine("Output");
        }
    }
}