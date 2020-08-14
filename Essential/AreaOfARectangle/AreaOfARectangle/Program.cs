using System;

namespace AreaOfARectangle
{
    class Program
    {
        // <summary>
        // This method displays area and perimeter
        // </summary>
        static void Main()
        {
            var rectangle = new Rectangle(20, 10);
            Console.WriteLine("Area: " + rectangle.Area);
            Console.WriteLine("Perimeter: " + rectangle.Perimeter);

            Console.ReadKey();
        }
    }
}
