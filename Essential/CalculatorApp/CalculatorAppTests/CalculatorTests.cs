using CalculatorApp;
using NSubstitute;
using Xunit;

namespace CalculatorAppTests
{
    public class CalculatorTests
    {
        private readonly Calculator _target;
        private readonly IConsole _console;

        public CalculatorTests()
        {
            _console = Substitute.For<IConsole>();
            _target = new Calculator(_console);
        }

        [Fact]
        public void MulTest_7_And_10_Returns_70()
        {
            // arrange
            var num = 7;
            bool isCalled = false;
            _console
                .When(x => x.WriteLine(70))
                .Do(x => isCalled = true);

            // action
            _target.Mul(num);

            // assert
            Assert.True(isCalled);
        }

        [Fact]
        public void MulTest_7_And_10_Returns_63()
        {
            // arrange
            var num = 7;
            bool isCalled = false;
            _console
                .When(x => x.Write(63))
                .Do(x => isCalled = true);

            // action
            _target.Mul(num);

            // assert
            Assert.True(isCalled);
        }
    }
}
