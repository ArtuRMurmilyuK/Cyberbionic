using ConvectorClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConvectorClassTest
{
    [TestClass]
    public class DollarTest
    {
        private Dollar _target;

        [TestInitialize]
        public void Initialize()
        {
            _target = new Dollar();
        }

        [TestMethod]
        public void DollarTest()
        {
            var result = _target.Dollar();

            Assert.AreEqual(7, result);
        }
    }
}
