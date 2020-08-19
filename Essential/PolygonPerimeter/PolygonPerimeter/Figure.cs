using System;

namespace PolygonPerimeter
{
    class Figure
    {
        private Point[] points;
        //Должен принимать Аргументы типа Point 
        public Figure()
        {
            Console.WriteLine("enter number of vertices of your figure");
            var number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                points[i] = new Point();
            }
        }
        double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        // Для того чтобы найти периметр многоугольника нам надо сложить все стороны. 
        public double PerimeterCalculator()
        {
            var perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter = (int) LengthSide(points[i - 1], points[i]);
            }

            perimeter += (int) LengthSide(points[0], points[points.Length]);
            return perimeter;
        }
    }
}
