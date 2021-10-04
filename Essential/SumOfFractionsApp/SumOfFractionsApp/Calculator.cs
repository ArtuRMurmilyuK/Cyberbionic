using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class Calculator
    {
        private Fraction _fraction1;
        private Fraction _fraction2;

        public Calculator()
        {
            InitFraction();
        }

        public void InitFraction()
        {
            _fraction1 = new Fraction(1, 2);
            _fraction2 = new Fraction(2, 5);
        }
        public double FindingTheDenominator()
        {
            var common = 0;

            for (int i = 1; i <= _fraction1.Denominator * _fraction2.Denominator; i++)
            {
                if (i % _fraction1.Denominator == 0 && i % _fraction2.Denominator == 0)
                {
                    common = i;
                    break;
                }
            }

            return common;
        }

        public Fraction SumFractions()
        {

            var numerical = _fraction1.Numerator * (FindingTheDenominator() / _fraction1.Denominator) +
                            _fraction2.Numerator * (FindingTheDenominator() / _fraction2.Denominator);

            var fraction = new Fraction(numerical, FindingTheDenominator());

            return fraction;
        }
    }
}