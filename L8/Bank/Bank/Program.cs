using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bank
{
    class Program
    {
        static void Bank(int sum, int pay, int debt)
        {
            var check = 0;
            while (check<=pay && sum<= debt)
            {
                Console.WriteLine("Enter sum payment");
                sum += int.Parse(Console.ReadLine());
                check++;
                if (sum < debt)
                {
                    Console.WriteLine("amount of debt:{0}", debt - sum);
                }

                if (sum >= debt)
                {
                    Console.WriteLine("No debt");
                }
            }

            if (sum > debt)
            {
                Console.WriteLine("overpayment: {0}", sum-debt );
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter bank debt: ");
            var debt = int.Parse(Console.ReadLine());
            int sum = 0;
            Console.WriteLine("Enter the number of payments:");
            var pay = int.Parse(Console.ReadLine());

            Bank(sum,pay,debt);
            Console.ReadKey();
        }
    }
}
