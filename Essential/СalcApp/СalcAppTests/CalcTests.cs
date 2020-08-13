using Xunit;
using СalcApp;

namespace СalcAppTests
{
    public class CalcTests
    {
        private Calc _target;

        public CalcTests()
        {
            _target = new Calc();
        }

        [Fact]
        public void SumTest()
        {
            var actual = _target.Sum(10, 20);
            Assert.Equal(30, actual);
        }
    }
}