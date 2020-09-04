using System;

namespace KentConv
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }

    }
}
