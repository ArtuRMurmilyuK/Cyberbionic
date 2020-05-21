using System;

namespace L5TASK1
{
    class Program
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Enter a parity number:");
            string input = Console.ReadLine();

            bool result = int.TryParse(input, out number);
            if (result == true)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number {0} is even", number);
                }
                else
                {
                    Console.WriteLine("Odd number{0}", number);
                }
                //Second metod
                if ((number & 1) == 0)
                {
                    Console.WriteLine("The number {0} is even", number);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Odd number{0}", number);
                    Console.ReadKey();
                }
            }

            else
            {
                Console.WriteLine("No number entered");
                Console.ReadKey();
            }
        }
    }
}
