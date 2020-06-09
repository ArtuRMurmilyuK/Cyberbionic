using System;
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
            _target = new Calculate();
        }

        [TestMethod]
        public void AddTest()
        {
            var actual = _target.Add(2, 3);
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        
        public void AddMaxValueTest()
        {
             _target.Add(int.MaxValue, 1);
        }

        [TestMethod]
        public void MulTest()
        {
            var actual = _target.Mul(2, 6);
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void DivTest()
        {
            var actual = _target.Div(12, 4);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivDivideByZeroTest()
        {
            _target.Div(12, 0);
        }

        [TestMethod]
        
        public void SubTest()
        {
            var actual = _target.Sub(6, 3);
            Assert.AreEqual( 3, actual);
        }
    }
}