using System;

namespace CarProgram
{
    internal interface ITransmission
    {
        void ChoiceTransmission();
    }

    internal class AutoTransmission : ITransmission
    {
        public void ChoiceTransmission()
        {
            Console.WriteLine("It`s auto transmission");
        }
    }
    internal class ManualTransmission : ITransmission
    {
        public void ChoiceTransmission()
        {
            Console.WriteLine("It`s manual transmission");
        }
    }
}
