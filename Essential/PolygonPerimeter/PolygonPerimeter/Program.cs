using System;
using PolygonPerimeter.Model;

namespace PolygonPerimeter
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter number of vertices of your figure: ");
            var length = int.Parse(Console.ReadLine());
            var points = new Point[length];
            for (var i = 0; i < length; i++)
            {
                Console.Write("Enter X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter Y: ");
                int y = int.Parse(Console.ReadLine());

                Console.Write("Enter Name: ");
                var name = Console.ReadLine();

                points[i] = new Point(x, y, name);
            }

            var figure = new Figure(points);
            
            
            Console.WriteLine(figure.PerimeterCalculator());
            Console.ReadKey();
        }
    }
}
