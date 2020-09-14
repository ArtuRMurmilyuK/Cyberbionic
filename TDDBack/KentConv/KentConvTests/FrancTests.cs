using KentConv;
using Xunit;

namespace KentConvTests
{
    public class FrancTests
    {
        private readonly Franc _target;

        public FrancTests()
        {
            _target = new Franc(10, "CHF");
        }

        [Fact]

        public void Times_Money()
        {
            //Arrange
            var multiplier = 2;

            //Act
            var actual = _target.Times(multiplier);

            //Assert
            Assert.Equal(20, actual.Amount);
            Assert.Equal("CHF", actual.Currency);
        }
    }
}
