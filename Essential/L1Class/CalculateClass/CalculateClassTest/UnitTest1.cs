using CalculateClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateClassTest
{
    [TestClass]
    public class CalculateTest
    {
        private Calculate _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new Calculate(2, 3);
        }

        [TestMethod]
        public void AddTest()
        {
            var result = _target.Add();

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void MulTest()
        {
            var result = _target.Mul();

            Assert.AreEqual(6, result);
        }
    }
}
