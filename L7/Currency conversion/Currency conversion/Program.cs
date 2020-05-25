using System;

namespace Currency_conversion
{
    class Program
    {
        static double Conventional_money(double a, double b)
        {
            return  a / b;
        }
        static void Main()
        {
            var money = 0d;
            var course = 0d;
            var result = 0m;
            string carentlyAfter = null;
            Console.WriteLine("Enter the currency you want to exchange:");
            var carentlyBefore = Console.ReadLine();

            Console.WriteLine("Enter the amount of money:");
            var stringMoney = Console.ReadLine();
            var checkMoney = double.TryParse(stringMoney, out money);
            if (checkMoney)
            {
                Console.WriteLine("Enter what currency you want to receive:");
                carentlyAfter = Console.ReadLine();
                

                Console.WriteLine("Enter the rate to convert to another currency:");
                var stringCourse = Console.ReadLine();
                var check = double.TryParse(stringCourse, out course);
                if (check)
                {
                    result =  (decimal) Conventional_money(money, course);
                }
            }

            Console.WriteLine("{0} {1}", result, carentlyAfter);
            Console.ReadKey();
        }

    }
}
