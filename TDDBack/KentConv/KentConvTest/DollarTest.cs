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
            Money five = Money.dollar(5);
            
            Assert.Equal(Money.dollar(10).GetHashCode(), five.Times(2).GetHashCode());
            Assert.Equal(Money.dollar(15).GetHashCode(), five.Times(3).GetHashCode());
        }

        [Fact]
        public void EqualityTest()
        {
            Assert.True(Money.dollar(5).equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).equals(Money.dollar(6)));

            Assert.True(new Franc(5).equals(new Franc(5)));
            Assert.False(new Franc(5).equals(new Franc(6)));

            Assert.False(new Franc(5).equals(Money.dollar(5)));
        }

        [Fact]
        public void FrancMultiplicationTest()
        {
            Money five = Money.franc(5);
            Assert.Equal(Money.franc(10).GetHashCode(),  five.Times(2).GetHashCode());
            Assert.Equal(Money.franc(10).GetHashCode(), five.Times(3).GetHashCode());
        }

        [Fact]
        public void CurrencyTest()
        {
            Assert.Equal("USD", Money.dollar(1).currency());
            Assert.Equal("CHF", Money.franc(1).currency());
        }
    }

    
}
