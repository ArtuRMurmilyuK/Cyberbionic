using System;
using System.Collections.Generic;
using PlateService.Factories;
using PlateService.Services;

namespace PlateService
{
    class Program
    {
        static void Main()
        {
            
            var glass = new GlassPlate();
            var metal = new MetalPlate();
            var clay = new ClayPlate();

            var list = new List<IFactory>() {glass, metal, clay};
            
            var ser = new Service(list);
            ser.ChangeFactory<GlassPlate>();
            ser.Relies();
            ser.ChangeFactory<MetalPlate>();
            ser.Relies();
            ser.ChangeFactory<ClayPlate>();
            ser.Relies();

            Console.ReadKey();
        }
    }
}
