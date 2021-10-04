using System;

namespace PoundConvectorApp
{
    class MyConsole
    {
        private readonly Convector _convector;

        public MyConsole()
        {
            _convector = new Convector();
        }

        public void Display()
        {
            Console.WriteLine(_convector.NewPound());
        }
    }
}