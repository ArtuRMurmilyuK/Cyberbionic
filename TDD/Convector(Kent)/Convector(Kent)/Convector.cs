namespace ConvectorKent
{
    public class Dollar
    {
        public int Amount;
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public int Times(int multiplier)
        {
            var result = Amount * multiplier;
            return result;
        }
    }
}