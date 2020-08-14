using Xunit;
using AreaOfARectangle;

namespace AreaOfARectangleTests
{
    public class RectangleTests
    {
        // init target 
        private readonly Rectangle _target;

        public RectangleTests()
        {
            _target = new Rectangle(2, 3);
        }

        //Test method PerimeterCalculator
        [Fact]
        public void PerimeterCalculatorTest()
        {
            var actual = _target.PerimeterCalculator(2, 3);
            Assert.Equal(10, actual);
        }
        //Test method AreaCalculator
        [Fact]
        public void AreaCalculatorTests()
        {
            var actual = _target.AreaCalculator(2, 3);
            Assert.Equal(6, actual);
        }
    }
}