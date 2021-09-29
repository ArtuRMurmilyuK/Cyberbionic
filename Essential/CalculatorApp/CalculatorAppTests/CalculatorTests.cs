using CalculatorApp;
using Xunit;

namespace CalculatorAppTests
{
    public class CalculatorTests
    {
        private readonly Calculator _target;

        public CalculatorTests()
        {
            _target = new Calculator();
        }

        [Fact]
        public int MulTests()
        {
            // Arrange

            var num = 7;

            // Act
            var res = 0;

            for (int i = 0; i < 10; i++)
            {
                res += num;
            }

            // Assert
            Assert.Equal(70, res);
            return 0;
        }
    }
}
