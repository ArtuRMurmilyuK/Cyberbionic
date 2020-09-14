using System;
using System.Collections.Generic;
using System.Text;

namespace KentConv
{
    public abstract class Money
    {
        public abstract Money Times(int multiplier);
        public int amount;
        protected String currency;

        public Boolean equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && GetType() == money.GetType();// getClass.equals(money.getClass) in JAVA
        }

        public static Money dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        String currency()
        {
            return currency;
        }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }
    }
}
