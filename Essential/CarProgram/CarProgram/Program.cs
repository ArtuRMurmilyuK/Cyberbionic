using System;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var gasEngine = new GasEngine();
            var elecEngine = new ElecEngine();

            var autoTransmission = new AutoTransmission();
            var manualTransmission = new ManualTransmission();

            
           

            Console.Write("Select engine.\n 1-Gas\n 2-Elec\n ");
            var select = Int32.Parse(Console.ReadLine());
            IEngine selectedEngine = null;

            switch (select)
            {
                case 1:
                {
                    selectedEngine = gasEngine;
                    break;
                }
                case 2:
                {
                    selectedEngine = elecEngine;
                    break;
                }
            }

            Console.Write("Select transmission.\n 1-Auto\n 2-Manual\n");
            select = Int32.Parse(Console.ReadLine());
            ITransmission selectedTransmission = null;
            switch (select)
            {
                case 1:
                {
                    selectedTransmission = autoTransmission;
                    break;
                }
                case 2:
                {
                    selectedTransmission = manualTransmission;
                    break;
                }
            }

            var car = new Car(selectedEngine, manualTransmission);
            car.ChosenEngine();
            car.ChosenTransmission();
        }
    }
}
