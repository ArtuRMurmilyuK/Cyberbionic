namespace KentConv
{
    public class Dollar : Money
    {
        private string currency;
        public Dollar(int amount, string currency) : base(amount, currency)
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

        public string Сurrency => currency;
    }
}
