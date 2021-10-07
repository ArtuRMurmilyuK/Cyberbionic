namespace PoundConvectorApp.Models
{
    class OldPound
    {
        public decimal Pound { get;}
        public decimal Shilling { get;}
        public decimal Pennies { get; }

        public OldPound(decimal pound, decimal shilling, decimal pennies)
        {
            Pound = pound;
            Shilling = shilling;
            Pennies = pennies;
        }
    }
}