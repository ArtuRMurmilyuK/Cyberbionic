using System;
using ConvHalonsToFeet;
using Xunit;

namespace ConvHalonsToFeetTest
{
    public class ConvectorTests
    {
        private readonly Convector _target;
        private readonly double _tolerance = 0.001;

        public ConvectorTests()
        {
            _target = new Convector();
        }

        [Fact]
        public void Transformation()
        {
            // arrange
            var gallon = 15;

            var expected = 2.005;

            // action
            var actual = _target.GallonToFoot(gallon);

            // assert
            Assert.True(expected - actual < _tolerance);
        }
    }
}
