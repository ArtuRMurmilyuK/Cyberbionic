using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class Convector
    {
        public Fraction CreateFractionFromString(string str)
        {
            string[] parts = str.Split("/");

            return new Fraction(int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }
}