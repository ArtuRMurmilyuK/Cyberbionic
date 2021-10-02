namespace SumOfFractionsApp
{
    class Program
    {
        static void Main()
        {
            var calc = new Calculator();
            var cons = new MyConsole();
            cons.Display(calc.SumFractions());
        }
    }
}
