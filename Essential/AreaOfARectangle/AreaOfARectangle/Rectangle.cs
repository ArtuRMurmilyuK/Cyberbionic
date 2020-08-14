namespace AreaOfARectangle
{
    // <summary>
    // This class computes Area and Perimeter
    // </summary>
    public class Rectangle
    {
        // <summary>
        // initialized with argument values
        // </summary>
        private readonly double _side1;
        private readonly double _side2;

        // <summary>
        // Access modifier
        // </summary>
        public double Area => AreaCalculator(_side1, _side2);
        public double Perimeter => PerimeterCalculator(_side1, _side2);

        public Rectangle(double side1, double side2)
        {
            _side1 = side1;
            _side2 = side2;
        }

        // <summary>
        // Calculate the area
        // </summary>
        public double AreaCalculator(double side1, double side2)
        {
            return side1 * side2;
        }
        // <summary>
        // Calculates the perimeter
        // </summary>
        public double PerimeterCalculator(double side1, double side2)
        {
            return side1 + side1 + side2 + side2;
        }
    }
}