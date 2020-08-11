using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalc;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalc.Tests
{
    [TestClass()]
    public class MyCalcTests
    {
        [TestMethod()]
        public void SumTest()
        {
            int x = 10;
            int y = 20;
            int expected = 30;

            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}