using Xunit;
using SumOfFractionsApp;
using SumOfFractionsApp.Models;

namespace SumOfFractionsAppTests
{
    public class CalculatorTests
    {
        private readonly Calculator _target;

        public CalculatorTests()
        {
            _target = new Calculator();
        }

        [Fact]
        public void Sum_Return9_10()
        {
            //arrange
            double denominator = 10; 

            Fraction var1 = new Fraction(1,2);
            Fraction var2 = new Fraction(2, 5);
            var expected = new Fraction(9,10);

            //action
            var newFraction = _target.Sum(var1,var2);
            
            //assert
            Assert.Equal(expected, newFraction);
        }
    }
}
