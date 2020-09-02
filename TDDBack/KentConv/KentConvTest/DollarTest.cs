using System;
using Xunit;

namespace KentConvTest
{
    public class Program
    {
        [Fact]
        public void MultiplicationTest()
        {
            Dollar five = new Dollar(5);
            Assert.Equal(new Dollar(10),five.Times(2));
            Assert.Equal(new Dollar(15),five.Times(3));
        }

        [Fact]
        public void EqualityTest()
        {
            Assert.True(new Dollar(5).equals(new Dollar(5)));
            Assert.False(new Dollar(5).equals(new Dollar(6)));
        }

        [Fact]
        public void FrancMultiplicationTest()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10),  five.Times(2));
            Assert.Equal(new Franc(15), five.Times(3));
        }
    }

    
}
