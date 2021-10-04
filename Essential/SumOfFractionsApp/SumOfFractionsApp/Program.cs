using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    class Program
    {
        static void Main()
        {
           
            var cons = new MyConsole(new Fraction(1,2), new Calculator());
            cons.DisplaySumFraction();
        }
    }
}
