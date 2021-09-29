using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main()
        {
        }
    }

    public class Calculator
    {
        public void Mul(int num)
        {
            for (int i = 0, k = num; i < 30; i++)
            {
                if (i == 9 || i == 19)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.Write(num);
                }
                num += k;
            }
        }
    }
}
