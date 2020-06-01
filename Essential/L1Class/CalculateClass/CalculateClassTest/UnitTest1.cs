using CalculateClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculateClassTest
{
    [TestClass]
    public class UserTests
    {
        private User _target;

        [TestInitialize]
        public void Initialize()
        {
            _target=new User();
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.Fail();
        }
    }
}
