using Xunit;
using Converter;

namespace ConverterTests
{
    public class ConverterTests
    {
        [Fact]
        public void ConvertersTest()
        {
            var GrnValue = 2.0;
            string Money = "Grn" ;
            var ConvetTo = "Usd";
            var Value = 0.0;
            if (Money == "Grn")
            {
                switch (ConvetTo)
                {
                    case "Usd":
                        Value = GrnValue * 27.44;
                        break;
                    case "Eur":
                        Value = GrnValue * 32.37;
                        break;
                    case "Rub":
                        Value = (int) (GrnValue * 0.37);
                        break;
                        
                }
            }
            else if(Money == "Usd")
            {
                Value = GrnValue / 27.44;
            }
            else if (Money == "Eur")
            {
                Value = GrnValue / 32.37;
            }
            else
            {
                Value = GrnValue/ 0.37;
            }
        }
    }
}