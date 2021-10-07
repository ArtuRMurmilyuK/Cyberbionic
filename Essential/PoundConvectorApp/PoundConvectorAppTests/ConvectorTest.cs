using System;
using PoundConvectorApp;
using PoundConvectorApp.Models;
using Xunit;

namespace PoundConvectorAppTests
{
    public class ConvectorTest
    {
        private Convector _target;

        public ConvectorTest()
        {
            _target = new Convector();
        }

        [Fact]
        public void Return_NewPound()
        {
            //arrange
            
            var expected = new NewPound(7, 88.75M);

            //action
            var actual = _target.NewPound(7,17,9);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
