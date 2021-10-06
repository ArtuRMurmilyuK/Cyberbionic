using System.Linq.Expressions;
using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    class Program
    {
        static void Main()
        {
            var convector = new Convector();
            var console = new ConsoleWrapper();
            var calc = new Calculator();

            Fraction a = convector.StringToFraction("1/2");
            Fraction b = convector.StringToFraction("2/5");

            var newFraction = calc.SumFractions(a, b);
            console.WriteLine($"{newFraction.Numerator}/{newFraction.Denominator}");
        }
    }
}
