using System;

namespace Сhecking_numbers
{
    class Program
    {
        static int EnterValue(int a)
        {
            
            while (true)
            {
                var stringNum = Console.ReadLine();
                var check = int.TryParse(stringNum, out a);
                if (check) break;
            }
            return a;
        }

        static void Checking(int num)
        {
            if (num <= 0)
            {
                 Console.WriteLine("negative number");
            }
            else if(num > 0)
            {
                 Console.WriteLine("Positive number");
            }

            var a = 2;
            var k = 0;

            while (a<10)
            {
                if (num % a == 0)
                {
                    Console.WriteLine("divide by "+ "{0}" + " without a remainder", a);
                }
                else if(num % a != 0)
                {
                    Console.WriteLine("divide by " + "{0}" + " with a remainder", a);
                }

                if (num % a == 0 && num / num ==1 )
                {
                    k++;
                }
                
                a++;
            }

            if (k <= 2)
            {
                Console.WriteLine("Number {0} simple",num);
            }
            else
            {
                Console.WriteLine("Number {0} unease", num);
            }
        }
        static void Main()
        {
            var num = 0;
            
            Console.WriteLine("Enter a number");
            num = EnterValue(num);
            Checking(num);
            Console.ReadKey();
        }
    }
}
