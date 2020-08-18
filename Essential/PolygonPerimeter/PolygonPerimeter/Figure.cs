using System;

namespace PolygonPerimeter
{
    class Figure
    {
        //Должен принимать Аргументы типа Point 
        public Figure()
        {

        }
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.X - B.X, 2) + Math.Pow(A.Y - B.Y, 2));
        }
        // Для того чтобы найти периметр многоугольника нам надо сложить все стороны. 
        public double PerimeterCalculator()
        {
            var perimeter = 0;
            return perimeter;
        }
    }
}
