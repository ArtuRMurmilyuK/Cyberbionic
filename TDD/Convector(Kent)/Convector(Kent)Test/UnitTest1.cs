using System.ComponentModel.DataAnnotations;
using ConvectorKent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Convector_Kent_Test
{
    [TestClass]
    public class DollarTest
    {
        private Dollar _target;

        [TestInitialize] 
          public void Initialize()
          {
              _target = new Dollar(5);
          }

          [TestMethod]
          public void TimesTest()
          {
              var result = _target.Times(2);

              Assert.AreEqual(10, result);
          }

    }
}
