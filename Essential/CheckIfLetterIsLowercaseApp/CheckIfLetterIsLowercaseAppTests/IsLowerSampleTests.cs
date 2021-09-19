using CheckIfLetterIsLowercaseApp;
using Xunit;

namespace CheckIfLetterIsLowercaseAppTests
{
    public class IsLowerSampleTests
    {
        private readonly IsLowerSample _target;

        public IsLowerSampleTests()
        {
            _target = new IsLowerSample();
        }

        [Fact]
        public void Check()
        {
            // arrange
            var ch = 'a';

            // action
            var actual = _target.Check(ch);

            // assert
            Assert.Equal(1, actual);
        }
    }
}
