using KentConv;
using Xunit;

namespace KentConvTests
{
    public class DollarTests
    {
        private readonly Dollar _target;

        public DollarTests()
        {
            _target = new Dollar(10, "USD");
        }

        [Fact]
        public void Times_Money()
        {
            // Arrange
            var multiplier = 2;
            
            // Act
            var actual = _target.Times(multiplier);

            // Assert
            Assert.Equal(20, actual.Amount);
            Assert.Equal("USD", actual.Currency);
        }
    }

    
}
