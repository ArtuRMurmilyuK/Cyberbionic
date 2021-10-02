using System;
using System.Linq;

namespace SumOfFractionsApp
{
    public class FractionOperation
    {
        private string _firstFraction;
        private string _secondFraction;
        public FractionOperation(string firstFraction, string secondFraction)
        {
            _firstFraction = firstFraction;
            _secondFraction = secondFraction;
        }
        
        public char[] ConvertStringToFraction(string str)
        {
            char[] newArray = {str[0], str[2]};

            return newArray;
        }

        public int FindingTheDenominator()
        {
            int[] fraction1 = ConvertStringToFraction(_firstFraction).Select(c => Convert.ToInt32(c.ToString())).ToArray();
            int[] fraction2 = ConvertStringToFraction(_secondFraction).Select(c => Convert.ToInt32(c.ToString())).ToArray();

            var common = 0;

            for (int i = 1; i <= fraction1[1] * fraction2[1]; i++)
            {
                if (i % fraction1[1] ==0  && i % fraction2[1] == 0)
                {
                    common = i;
                    break;
                }
            }

            return common;
        }

        public string ImproperFractionCon(string arg)
        {
            int[] fraction1 = ConvertStringToFraction(arg).Select(c => Convert.ToInt32(c.ToString())).ToArray();
            var improperFraction = $"{fraction1[0] * FindingTheDenominator() / fraction1[1]}/{FindingTheDenominator()}";

            return improperFraction;
        }


        public string SumFractions()
        {
            var fraction1 = ImproperFractionCon(_firstFraction);
            var fraction2 = ImproperFractionCon(_secondFraction);

            var numerical = int.Parse(fraction1[0].ToString()) + int.Parse(fraction2[0].ToString());

            var fraction = $"{numerical}/{FindingTheDenominator()}";

            return fraction;
        }
    }
}