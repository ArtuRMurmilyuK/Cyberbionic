using System;

namespace PoundConvectorApp
{
    class ConsoleWrapper : IConsole
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