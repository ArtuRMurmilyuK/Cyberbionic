using System;

namespace PlateService.Factories
{
    public class GlassPlate : IFactory
    {
        public void ReleaseThePlate()
        {
            Console.WriteLine("Glass");
        }
    }
}