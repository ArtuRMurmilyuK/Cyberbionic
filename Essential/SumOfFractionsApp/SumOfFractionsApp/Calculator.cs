using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class Calculator
    {
        public Fraction Sum(Fraction a, Fraction b)
        {
           double denominator = FindingTheDenominator(a, b);

            var numerical = a.Numerator * (denominator / a.Denominator) +
                            b.Numerator * (denominator / b.Denominator);

            return new Fraction(numerical, denominator);
        }

        private double FindingTheDenominator(Fraction a , Fraction b )
        {
            int denominator = 0;
            for (int i = 1; i <= a.Denominator * b.Denominator; i++)
            {
                if (i % a.Denominator == 0 && i % b.Denominator == 0)
                {
                    denominator = i;
                    break;
                }
            }

            return denominator;
        }
    }
}