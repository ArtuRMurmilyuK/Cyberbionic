using System;
using ConvertLbApp;
using Xunit;

namespace ConvertLbAppTests
{
    public class ConvectorTests
    {
        private readonly Convector _target;

        public ConvectorTests()
        {
            _target = new Convector();
        }

        [Fact]
        public float LbTests()
        {
            // Arrange
            const float oneLb = 1.487f;
            var money = 50;

            // Act
            var lb = Math.Round( money/ oneLb, 2);

            // Assert
            Assert.Equal(33.62, lb);
            return 0;
        }
    }
}
