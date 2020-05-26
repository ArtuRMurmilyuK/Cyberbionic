using System;

namespace Metod_Calculate__int_5_
{
    class Program
    {
        static int EnterValue(int num)
        {
            var stringNum = Console.ReadLine();
            var check = int.TryParse(stringNum, out num);
            if (check)
            {
                return num;
            }
            else return EnterValue(num);
        }

        static (int, int, int) Calculate(int firstNum, int secondNum, int thirdNum)
        {
            return (firstNum /= 5, secondNum /= 5, thirdNum /= 5);
        }
        static void Main()
        {
            var firstNum = 0;
            var secondNum = 0;
            var thirdNum = 0;

            Console.WriteLine("Enter first number:");
            firstNum = EnterValue(firstNum);
            Console.WriteLine("Enter second number:");
            secondNum = EnterValue(secondNum);
            Console.WriteLine("Enter third number:");
            thirdNum = EnterValue(thirdNum);
            Console.WriteLine(Calculate(firstNum, secondNum, thirdNum));
            Console.ReadKey();

        }
    }
}
