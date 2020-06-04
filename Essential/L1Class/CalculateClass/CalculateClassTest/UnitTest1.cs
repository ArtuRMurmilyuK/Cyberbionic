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
            _target = new Calculate(6, 3);
        }

        [TestMethod]
        public void AddTest()
        {
            var result = _target.Add();

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void MulTest()
        {
            var result = _target.Mul();

            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void OddTest()
        {
            var result = _target.Odd();

            Assert.AreEqual(2 ,result);
        }

        [TestMethod]
        public void SubtractionTest()
        {
            var result = _target.Sub();

            Assert.AreEqual( 3 , result);
        }
    }
}
