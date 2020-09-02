using System;
using System.Collections.Generic;
using System.Text;

namespace KentConvTest
{
    class Dollar
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        private int amount;
        public Boolean equals(Object obj)
        {
            Dollar dollar = (Dollar)obj;
            return amount == dollar.amount;
        }
    }
}
