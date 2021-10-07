using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    class Program
    {
        static void Main()
        {
            var convector = new Convector();
            Fraction a = convector.CreateFractionFromString("1/2");
            Fraction b = convector.CreateFractionFromString("2/5");

            var calc = new Calculator();
            var newFraction = calc.Sum(a, b);

            var console = new ConsoleWrapper();
            console.WriteLine($"{newFraction.Numerator}/{newFraction.Denominator}");
        }
    }
}
