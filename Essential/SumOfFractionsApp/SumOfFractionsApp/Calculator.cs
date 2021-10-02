namespace SumOfFractionsApp
{
    public class Calculator
    {
        private readonly Fraction _fraction1;
        private readonly Fraction _fraction2;

        public Calculator()
        {
            _fraction1 = new Fraction{ Numerator = 1, Denominator = 2};
            _fraction2 = new Fraction { Numerator = 2 ,Denominator = 5 };
        }
        public int FindingTheDenominator()
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

        public string SumFractions()
        {

            var numerical = _fraction1.Numerator * (FindingTheDenominator() / _fraction1.Denominator) +
                            _fraction2.Numerator * (FindingTheDenominator() / _fraction2.Denominator);

            var fraction = $"{numerical}/{FindingTheDenominator()}";

            return fraction;
        }
    }
}