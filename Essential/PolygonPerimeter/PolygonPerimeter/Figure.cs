using System;
using PolygonPerimeter.Model;

namespace PolygonPerimeter
{
    public class Figure
    {
        private readonly Point[] _points;

        public Figure(Point[] points)
        {
            _points = points;
        }

        private double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public double PerimeterCalculator()
        {
            var perimeter = 0;
            for (var i = 1; i < _points.Length; i++) perimeter = (int) LengthSide(_points[i - 1], _points[i]);

            perimeter += (int) LengthSide(_points[0], _points[_points.Length]);
            return perimeter;
        }
    }
}