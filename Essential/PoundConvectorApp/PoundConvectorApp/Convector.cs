using System;

namespace PoundConvectorApp
{
    class Convector
    {
        private Values _values;

        public Convector()
        {
            Init();
        }

        public void Init()
        {
            _values = new Values(7, 22, 9); 
        }

        public double NewPound()
        {
            var result = PenniesToPound() != 0 
                ? $"{_values._pound+ PenniesToPound()},{Math.Round(ShillingToPennies()) - 100 * PenniesToPound()}"
                : $"{ _values._pound},{Math.Round(ShillingToPennies())}";

            return StingToDouble(result);
        }

        public int PenniesToPound()
        {
            if (ShillingToPennies() >= 100)
            {
                return  (int)(ShillingToPennies() / 100);
            }

            return 0;
        }

        public double StingToDouble(string str)
        {
            return Convert.ToDouble(str);
        }

        public double ShillingToPennies()
        {
            return  (_values._shilling * ConsMoney.ShillingToPennies + _values._pennies) / 2.4;
        }
    }
}