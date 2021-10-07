namespace PoundConvectorApp.Models
{
    public class NewPound
    {
        public decimal Pound { get; }
        public decimal Pennies { get; }

        public NewPound(decimal pound, decimal pennies)
        {
            Pound = pound;
            Pennies = pennies;
        }
    }
}