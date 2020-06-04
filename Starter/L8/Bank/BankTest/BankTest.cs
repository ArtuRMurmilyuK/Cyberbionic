using NUnit.Framework;

namespace BankTest
{
    [TestCase]
    public class Bank
    {
        private Bank _target;

        [TestInitialize]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}