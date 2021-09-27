using System;
using FahrenheitEquivalentApp;
using Xunit;

namespace FahrenheitEquivalentAppTests
{
    public class ConvectorTests
        {
            private readonly Convector _target;

            public ConvectorTests()
            {
                _target = new Convector();
            }

            [Fact]
            public float CelsiusToFahrenheitTests()
            {
                // Arrange
                
                var celsius = 36.2;

                // Act
                var fahrenheit = Math.Round(celsius * 1.8 + 32, 2);

                // Assert
                Assert.Equal(97.16, fahrenheit);
                return 0;
            }
        }
    }

