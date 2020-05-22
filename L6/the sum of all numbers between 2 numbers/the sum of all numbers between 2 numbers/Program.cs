using System;

namespace the_sum_of_all_numbers_between_2_numbers
{
    class Program
    {
        static void Main()
        {
            var checkA = false;
            int A, B;
            do
            {
                Console.WriteLine("Enter A:");
                string valueA = Console.ReadLine();
                checkA = int.TryParse(valueA, out A);
                Console.WriteLine("Enter B:");
                string valueB = Console.ReadLine();
                checkA = int.TryParse(valueB, out B);
            } while (checkA == false);

            if (A < B)
            {
                int sum = 0;
                for (int num = ++A; num < B; num++)
                {
                    sum += num;
                    if (num % 2 == 0)
                    {
                        Console.WriteLine("Odd numbers = " + num);
                    }
                }
                Console.WriteLine("\nResult sum = " + sum);
            }

            else
            {
                Console.WriteLine("Error\nB<A");
                Console.ReadKey();
            }
        }
    }
}
