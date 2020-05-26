using System;

namespace Arithmetic_mean_using_method
{
    class Program
    {
        static int EnterValue(int num)
        {
            var stringValue = Console.ReadLine();
            var check = int.TryParse(stringValue, out num);
            if (check)
            {
                return num;
            }

            return  EnterValue(num);
        }

        static double Calculate( int firstnum,  int secondnum,  int thirdnum)
        {
            var result =(double) (firstnum + secondnum + thirdnum) / 3;
            return result;
        }

        static void Main()
        {
            var firstnum = 0;
            var secondnum = 0;
            var thirdnum = 0;
            
            Console.WriteLine("Enter first number:");
            firstnum =  EnterValue(firstnum);
            Console.WriteLine("Enter second number:");
            secondnum = EnterValue(secondnum);
            Console.WriteLine("Enter third number:");
            thirdnum = EnterValue(thirdnum);

            var result = Calculate(firstnum,  secondnum,  thirdnum);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
