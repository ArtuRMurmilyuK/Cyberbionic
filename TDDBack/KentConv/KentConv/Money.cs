using System;

namespace KentConv
{
    public abstract class Money
    {
        private readonly int _amount;
        private readonly string _currency;

        protected Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public int Amount
        {
            get { return _amount; }
        }

        public string Currency
        {
            get { return _currency; }
        }

        public abstract Money Times(int multiplier);

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public override bool Equals(object obj)
        {
            if(obj == null) throw new ArgumentNullException(nameof(obj));

            var money = (Money)obj;
            return _amount == money._amount 
                   && _currency == money._currency 
                   && GetType() == money.GetType();
        }
    }
}