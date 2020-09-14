using System;

namespace KentConv
{
    public class Franc : Money
    {
        private String currency;
        public Franc(int amount, String currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.franc(amount * multiplier);
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }

        String currency()
        {
            return currency;
        }
    }
}
