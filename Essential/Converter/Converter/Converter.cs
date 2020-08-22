using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Converter
{
    public class Converter
    {
        public static void Converters(double usd, double eur, double rub)
        {
            Console.Write("Enter value money: ");
            var GrnValue = double.Parse(Console.ReadLine());

            Console.Write("Enter currency: ");
            string Money = Console.ReadLine();

            Console.Write("Convert To: ");
            var ConvetTo = Console.ReadLine();

            var Value = 0.0;

            if (Money == "Grn")
            {
                switch (ConvetTo)
                {
                    case "Usd":
                        Value = GrnValue / 27.44;
                        break;
                    case "Eur":
                        Value = GrnValue / 32.37;
                        break;
                    case "Rub":
                        Value = (int)(GrnValue / 0.37);
                        break;

                }
            }
            else if (Money == "Usd")
            {
                Value = GrnValue * 27.44;
            }
            else if (Money == "Eur")
            {
                Value = GrnValue * 32.37;
            }
            else
            {
                Value = GrnValue * 0.37;
            }

            Console.WriteLine("After convert: " + Value);
        }
    }
}
