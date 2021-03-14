using System;

namespace PlateService.Factories
{
    public class MetalPlate : IFactory
    {
        public void ReleaseThePlate()
        {
            Console.WriteLine("Metal");
        }
    }
}