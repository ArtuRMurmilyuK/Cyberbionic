using System;

namespace Delivery
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
            
        }
        static void Main()
        {
            var n = 0;
            Console.WriteLine("Enter the number of customers:");
            var num = Console.ReadLine();
            var check = int.TryParse(num, out n);
            if (check)
            {
                n = Factorial(n);
                Console.WriteLine(n);
                Console.ReadKey();
            }
        }
    }
}
