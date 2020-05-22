using System;

namespace the_sum_of_all_numbers_between_2_numbers
{
    class Program
    {
        static void Main()
        {
            int A;
            Console.WriteLine("Enter A:");
            string valueA = Console.ReadLine();

            bool checkA = int.TryParse(valueA, out A);
            if (checkA == true)
            {
                int B;
                Console.WriteLine("Enter B:");
                string valueB = Console.ReadLine();

                bool checkB = int.TryParse(valueB, out B);
                if (checkB == true)
                {
                    if (A < B)
                    {
                        int sum = 0;
                        for (int num = ++A; num < B; num++)
                        {

                            sum += num;
                        }
                        Console.WriteLine("Result sum = " + sum);
                    }

                    if (A < B)
                    {
                        for (int num = ++A; num < B; num++)
                        {
                            if (num % 2 == 0)
                            {
                                Console.WriteLine("Odd numbers = " + num);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error\nB<A");
                        Console.ReadKey();
                    }
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
