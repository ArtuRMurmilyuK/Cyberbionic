using System;
using PoundConvectorApp.Models;

namespace PoundConvectorApp
{
    public class Convector
    {
        public NewPound NewPound(decimal pound, decimal shilling, decimal pennies)
        {
            var newPennies = ShillingToPennies(pound, shilling, pennies);
            var pounds = PenniesToPound(pound, shilling, pennies);

            var newPound = pounds != 0
                ? new NewPound(pound + pounds, newPennies - 100 * (int)pounds)
                : new NewPound(pound, newPennies);

            return newPound;
        }

        private decimal PenniesToPound(decimal pound, decimal shilling, decimal pennies)
        {
            var newPennies = ShillingToPennies(pound, shilling, pennies);

            if (newPennies >= 100)
            {
                return (newPennies / 100);
            }

            return 0;
        }

        private decimal ShillingToPennies(decimal pound, decimal shilling, decimal pennies)
        {
            return  (shilling * MoneyConstants.ShillingToPennies + pennies) / 2.4M;
        }
    }
}