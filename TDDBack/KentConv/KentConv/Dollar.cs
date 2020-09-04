using System;

namespace KentConv
{
    public class Dollar : Money
    {
        private String currency;
        public Dollar(int amount, String currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {
            return Money.dollar(amount * multiplier);
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }

        public String currency()
        {
            return currency;
        }
    }
}
