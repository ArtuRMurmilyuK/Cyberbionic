using System;
using ConvHalonsToFeet;
using Xunit;

namespace ConvHalonsToFeetTest
{
    public class ConvectorTests
    {
        private readonly Convector _target;

        public ConvectorTests()
        {
            _target = new Convector();
        }

        [Fact]
        public void Transformation()
        {
            // Arrange
            const double oneCubicFoot = 7.481;
            var gallon = 15;

            // Act
            var cubicFootResult = Math.Round(gallon / oneCubicFoot, 3);

            // Assert
            Assert.Equal(2.005, cubicFootResult);
        }
    }
}
