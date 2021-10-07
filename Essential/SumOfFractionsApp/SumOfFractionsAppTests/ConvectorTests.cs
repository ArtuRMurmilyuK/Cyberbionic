using Xunit;
using SumOfFractionsApp;
using SumOfFractionsApp.Models;

namespace SumOfFractionsAppTests
{
    public class ConvectorTests
    {
        private readonly Convector _target;

        public ConvectorTests()
        {
            _target = new Convector();
        }

        [Fact]
        public void CreateFractionFromStringTest()
        {
            //arrange
            string str = "1/2";
            var expected = new Fraction(1,2);

            //action
            var actual = _target.CreateFractionFromString(str);

            //assert
            Assert.Equal(expected,actual);
        }
    }
}