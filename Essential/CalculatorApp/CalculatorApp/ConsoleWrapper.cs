using System;

namespace CalculatorApp
{
    internal class ConsoleWrapper : IConsole
    {
        public void WriteLine(in int num)
        {
            Console.WriteLine(num);
        }

        public void Write(in int num)
        {
            Console.Write(num);
        }
    }
}