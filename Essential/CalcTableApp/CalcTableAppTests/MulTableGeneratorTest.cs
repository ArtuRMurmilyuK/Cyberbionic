using System;
using Xunit;

namespace CalcTableAppTests
{
    public class MulTableGeneratorTest
    {
        private MulTableGenerator _target;

        public MulTableGeneratorTest()
        {
            _target = new MulTableGenerator();
        }

        [Fact]
        public void Return_NewPound()
        {
            //arrange

            var expected = new NewPound(7, 88.75M);

            //action
            var actual = _target.NewPound(7, 17, 9);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}