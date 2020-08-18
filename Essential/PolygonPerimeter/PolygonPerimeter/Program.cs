using System;

namespace PolygonPerimeter
{
    class Program
    {
        static void Main()
        {
            Figure figure = new Figure();
            Console.WriteLine(figure.PerimeterCalculator());
            Console.ReadKey();
        }
    }
}
