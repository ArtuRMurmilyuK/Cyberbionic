using System;

namespace CalcTableApp
{
    class Program
    {
        static void Main()
        {
            var generator = new MulTableGenerator();
            var manager = new TableManager();
            do
            {
                var mulTab = generator.Create(2, 9);
                var tabParams = manager.Analyzation(mulTab);
                var tabBuilder = new TabBuilder(tabParams, mulTab);
                tabBuilder.Build();

                Console.WriteLine();
                Console.WriteLine("Exit: Q");
            } while (Console.ReadKey().Key == ConsoleKey.Q);
        }
    }

}
