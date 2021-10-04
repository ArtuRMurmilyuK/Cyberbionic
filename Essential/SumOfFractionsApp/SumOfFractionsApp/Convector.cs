using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class Convector
    {
        private readonly Fraction _fraction1;
        private readonly Calculator _calculator;

        public  Convector(string str)
        {
            _fraction1 = new Fraction (StringToFraction(str)[1], StringToFraction(str)[0]);
        }

        public char[] StringToFraction(string str)
        {
            char[] newArray = { str[0], str[2] };
            
            return newArray;
        }
        
        //public string ImproperFraction(string arg)
        //{
        //    
        //    var improperFraction = $"{_fraction1.Numerator * (_calculator.FindingTheDenominator() / _fraction1.Denominator)}/{_calculator.FindingTheDenominator()}";
        //
        //    return improperFraction;
        //}
    }
}