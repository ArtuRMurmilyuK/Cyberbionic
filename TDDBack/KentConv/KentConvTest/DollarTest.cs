using System;
using KentConv;
using Xunit;

namespace KentConvTest
{
    public class Program
    {
        [Fact]
        public void MultiplicationTest()
        {
            Dollar five = new Dollar(5);
            
            Assert.Equal(new Dollar(10).GetHashCode(), five.Times(2).GetHashCode());
            Assert.Equal(new Dollar(15).GetHashCode(), five.Times(3).GetHashCode());
        }

        [Fact]
        public void EqualityTest()
        {
            Assert.True(new Dollar(5).equals(new Dollar(5)));
            Assert.False(new Dollar(5).equals(new Dollar(6)));

            Assert.True(new Franc(5).equals(new Franc(5)));
            Assert.False(new Franc(5).equals(new Franc(6)));
        }

        [Fact]
        public void FrancMultiplicationTest()
        {
            Franc five = new Franc(5);
            Assert.Equal(new Franc(10).GetHashCode(),  five.Times(2).GetHashCode());
            Assert.Equal(new Franc(15).GetHashCode(), five.Times(3).GetHashCode());
        }
    }

    
}
