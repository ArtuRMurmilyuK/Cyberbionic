using Xunit;
using SumOfFractionsApp;

namespace SumOfFractionsAppTests
{
    public class FractionOperationTests
    {
        private readonly FractionOperation _target;

        public FractionOperationTests()
        {
            _target = new FractionOperation("1/2","2/5");
        }

        [Fact]
        public void Convert_String_Of_Fraction()
        {
            //arrange
            char [] expected = {'1','2'};

            //action
            var array = _target.ConvertStringToFraction("1/2");
            
            //assert
            Assert.Equal(expected, array);
        }

        [Fact]
        public void FindingTheDenominator_Return_10()
        {
            //arrange
            var expected = 10;

            //action
            var den = _target.FindingTheDenominator();

            //assert
            Assert.Equal(expected, den);
        }

        [Fact]
        public void ImproperFractionCon_Return_5_10()
        {
            //arrange
            var expected = "5/10";

            //action
            var improperFraction = _target.ImproperFractionCon("1/2");

            //assert
            Assert.Equal(expected, improperFraction);
        }

        [Fact]
        public void SumFraction_Return_9_10()
        {
            //arrange
            var expected = "9/10";

            //action
            var sumFraction = _target.SumFractions();

            //assert
            Assert.Equal(expected, sumFraction);
        }
    }
}
