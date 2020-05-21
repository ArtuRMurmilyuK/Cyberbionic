using System;

namespace L5TASK3
{
    class Program
    {
        static void Main()
        {
            int age;
            double prize, salary;

            Console.WriteLine("Enter your salary");
            string input1  = Console.ReadLine();

            bool result = double.TryParse(input1, out salary);
            if (result == true)
            {
                Console.WriteLine("Enter the years of service");
                string input = Console.ReadLine();

                bool result1 = int.TryParse(input, out age);
                if (result1 == true)
                {
                    if (age >= 0 && age < 5)
                    {
                        prize = salary * 10 / 100;
                        Console.WriteLine(prize);
                        Console.ReadKey();
                    }
                    else if(age >= 5 && age < 10)
                    {
                        prize = salary * 15 / 100;
                        Console.WriteLine(prize);
                        Console.ReadKey();
                    }
                    else if (age >= 10 && age < 15)
                    {
                        prize = salary * 25 / 100;
                        Console.WriteLine(prize);
                        Console.ReadKey();
                    }
                    else if (age >= 15 && age < 20)
                    {
                        prize = salary * 35 / 100;
                        Console.WriteLine(prize);
                        Console.ReadKey();
                    }
                    else if (age >= 20 && age < 25)
                    {
                        prize = salary * 45 / 100;
                        Console.WriteLine(prize);
                        Console.ReadKey();
                    }
                    else if (age >= 25)
                    {
                        prize = salary * 50 / 100;
                        Console.WriteLine(prize);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Not entered number");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Not entered number");
                Console.ReadKey();
            }
        }
    }
}
