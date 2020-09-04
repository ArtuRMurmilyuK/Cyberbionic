using System;

namespace KentConv
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override int GetHashCode()
        {
            return amount.GetHashCode();
        }
    }
}
