using System;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var car = new Car(selectedEngine, manualTransmission);
            car.ChosenEngine();
            car.ChosenTransmission();
            
        }
    }
}
