using System;
using PoundConvectorApp.Models;

namespace PoundConvectorApp
{
    class Convector
    {
        public NewPound NewPound(decimal pound, decimal shilling, decimal pennies)
        {
            var newPennies = ShillingToPennies(pound, shilling, pennies);
            var pounds = PenniesToPound(pound, shilling, pennies);

            var newPound = pounds != 0
                ? new NewPound(pound + pounds, Math.Round(newPennies) - 100 * pounds)
                : new NewPound(pound, Math.Round(newPennies));

            return newPound;
        }

        public int PenniesToPound(decimal pound, decimal shilling, decimal pennies)
        {
            var newPennies = ShillingToPennies(pound, shilling, pennies);

            if (newPennies >= 100)
            {
                return  (int) (newPennies / 100);
            }

            return 0;
        }

        public decimal ShillingToPennies(decimal pound, decimal shilling, decimal pennies)
        {
            return  (shilling * MoneyConstants.ShillingToPennies + pennies) / (decimal) 2.4;
        }
    }
}