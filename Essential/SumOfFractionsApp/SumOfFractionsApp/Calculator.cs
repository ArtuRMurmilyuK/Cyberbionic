using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class Calculator
    {
        private double _denominator;

        public double FindingTheDenominator(Fraction a , Fraction b )
        {
            for (int i = 1; i <= a.Denominator * b.Denominator; i++)
            {
                if (i % a.Denominator == 0 && i % b.Denominator == 0)
                {
                    _denominator = i;
                    break;
                }
            }

            return _denominator;
        }

        public Fraction SumFractions(Fraction a, Fraction b)
        {
            FindingTheDenominator(a, b);

            var numerical = a.Numerator * (_denominator / a.Denominator) +
                            b.Numerator * (_denominator / b.Denominator);

            return new Fraction(numerical, _denominator);
        }
    }
}