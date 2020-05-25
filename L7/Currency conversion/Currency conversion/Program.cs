﻿using System;

namespace Currency_conversion
{
    class Program
    {
        static double ConventionalMoney(double a, double b)
        {
            return  a / b;
        }

        static double EnterValue( double money)
        {
            var stringMoney = Console.ReadLine();
            var check = double.TryParse(stringMoney, out money);
            if (check)
            {
                return money;
            }

            return EnterValue(money);
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
            money = EnterValue( money);
            
            Console.WriteLine("Enter what currency you want to receive:");
            carentlyAfter = Console.ReadLine();

            Console.WriteLine("Enter the rate to convert to another currency:");
            course = EnterValue( course);
            
            result =  (decimal) ConventionalMoney(money, course);
            Console.WriteLine("{0} {1}", result, carentlyAfter);
            Console.ReadKey();
        }

    }
}
