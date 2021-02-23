using System;

namespace CarProgram.Info
{
    public interface IInfoMan
    {
        void BuyCar();
        void ChangeComponent();
        void CreateCar();

    }

    public class InfoMan : IInfoMan
    {
        private readonly ICarFactory 
        public void BuyCar()
        {
            //var gasEngine = new GasEngine();
            //var elecEngine = new ElecEngine();

            //var autoTransmission = new AutoTransmission();
            //var manualTransmission = new ManualTransmission();

            Console.Write("Select engine.\n 1-Gas\n 2-Elec\n ");
            var stringSelect = Console.ReadLine();
            string selectedEngine = null;

            switch (stringSelect)
            {
                case "1":
                {
                    selectedEngine = "gasEngine";
                    break;
                }
                case "2":
                {
                    selectedEngine = "elecEngine";
                    break;
                }
            }

            Console.Write("Select transmission.\n 1-Auto\n 2-Manual\n");
            stringSelect = Console.ReadLine();
            string selectedTransmission = null;
            switch (stringSelect)
            {
                case "1":
                {
                    selectedTransmission = "autoTransmission";
                    break;
                }
                case "2":
                {
                    selectedTransmission = "manualTransmission";
                    break;
                }
            }
        }

        public void ChangeComponent()
        {
            Console.Write("Select engine.\n 1-Gas\n 2-Elec\n ");
            var stringSelect = Console.ReadLine();
            string selectedEngine = null;

            switch (stringSelect)
            {
                case "1":
                {
                    selectedEngine = "gasEngine";
                    break;
                }
                case "2":
                {
                    selectedEngine = "elecEngine";
                    break;
                }
            }

            Console.Write("Select transmission.\n 1-Auto\n 2-Manual\n");
            stringSelect = Console.ReadLine();
            string selectedTransmission = null;
            switch (stringSelect)
            {
                case "1":
                {
                    selectedTransmission = "autoTransmission";
                    break;
                }
                case "2":
                {
                    selectedTransmission = "manualTransmission";
                    break;
                }
            }
        }

        public void CreateCar()
        {
            throw new NotImplementedException();
        }
    }
}