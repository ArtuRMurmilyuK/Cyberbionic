using System;

namespace CarProgram
{
    internal interface IEngine
    {
        void ChoiceEngine();
    }

    internal class GasEngine : IEngine
    {
        public void ChoiceEngine()
        {
            Console.WriteLine("It`s gas engine");
        }
    }

    internal class ElecEngine : IEngine
    {
        public void ChoiceEngine()
        {
            Console.WriteLine("It`s elec. engine");
        }
    }
}
