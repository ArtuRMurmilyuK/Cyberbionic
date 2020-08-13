using Microsoft.VisualStudio.TestTools.UnitTesting;
using СalcApp;

namespace СalcAppTests
{
    [TestClass]
    public class CalcTests
    {
        private Calc _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new Calc();
        }

        [TestMethod]
        public void SumTest()
        {
            var actual = _target.Sum(10, 20);
            Assert.AreEqual(30, actual);
        }
    }
}