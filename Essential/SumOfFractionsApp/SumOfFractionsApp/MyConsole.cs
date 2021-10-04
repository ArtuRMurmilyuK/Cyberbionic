using System;
using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class MyConsole
    {
        private readonly Fraction _fraction;
        private Calculator _calculator;
        public MyConsole(Fraction fraction, Calculator calculator)
        {
            _calculator = calculator;
            _fraction = _calculator.SumFractions();
        }

        public void DisplaySumFraction()
        {
            Console.WriteLine($"{_fraction.Numerator}/{_fraction.Denominator}");
        }
    }
}