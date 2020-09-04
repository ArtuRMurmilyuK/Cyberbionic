using System;
using System.Collections.Generic;
using System.Text;

namespace KentConv
{
    public class Money
    {
        public int amount;

        public Boolean equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }
    }
}
