﻿using System;

namespace Delivery
{
    class Program
    {
        static int Factorial(int n)
        {
            var result = (n == 0) ? 1 :  n * Factorial(n - 1);
            return result;
        }
        static void Main()
        {
            
            Console.WriteLine("Enter the number of customers:");
            var num = Console.ReadLine();
            if (int.TryParse(num, out var n))
            {
                n = Factorial(n);
                Console.WriteLine(n);
                Console.ReadKey();
            }
        }
    }
}
