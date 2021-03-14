using System;

namespace PlateService.Factories
{
    public class ClayPlate : IFactory
    {
        public void ReleaseThePlate()
        {
            Console.WriteLine("Clay");
        }
    }
}