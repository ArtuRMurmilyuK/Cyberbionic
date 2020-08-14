namespace AreaOfARectangle
{
    public class Rectangle
    {
        private double _side1, _side2;

        public double Area => AreaCalculator(20, 10);

        public double Perimeter => PerimeterCalculator(20, 10);

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }
        public double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }

        public double PerimeterCalculator(double side1, double side2)
        {
            return side1 + side1 + side2 + side2;
        }
    }
}