using System;

namespace L4TASK2
{
    class Program
    {
        static void Main()
        {
            float number;
            Console.WriteLine("Enter number 0-100:");
            string input = Console.ReadLine();

            bool result = float.TryParse(input, out number);
            if (result == true )
            {
                if (number>=0 && number <=100)
                {
                    if (number >= 0 && number <= 14)
                    {
                        Console.WriteLine("Range [0-14]");
                        Console.ReadKey();
                    }
                    else if(number >= 15 && number <= 35)

                    {
                        Console.WriteLine("Range [15-35]");
                        Console.ReadKey();
                    }
                    else if (number >= 36 && number <= 49)
                    {
                        Console.WriteLine("Range [36-49] ");
                        Console.ReadKey();
                    }
                    else if (number >= 50 && number <= 100)
                    {
                        Console.WriteLine("Range [50-100] ");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("ERROR\nIncorrect number entered");
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
