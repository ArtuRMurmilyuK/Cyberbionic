using System;

namespace SumOfFractionsApp
{
    class Program
    {
        static void Main()
        {
            var operation = new FractionOperation("1/2", "2/5");
            Console.WriteLine(operation.SumFractions());
        }
    }
}
