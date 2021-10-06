using System;

namespace SumOfFractionsApp
{
    internal class ConsoleWrapper : IConsole
    {
        public void WriteLine(object obj)
        {
            Console.WriteLine(obj);
        }

        public void Write(object obj)
        {
            Console.Write(obj);
        }
    }
}