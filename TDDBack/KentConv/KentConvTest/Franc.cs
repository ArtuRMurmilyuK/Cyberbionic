using System;
using System.Collections.Generic;
using System.Text;

namespace KentConvTest
{
    class Franc
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        private int amount;
        public Boolean equals(Object obj)
        {
            Franc franc = (Franc)obj;
            return amount == franc.amount;
        }
    }
}
