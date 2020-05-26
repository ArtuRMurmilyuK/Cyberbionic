using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Bank
{
    class Program
    {
        static void Bank(int sum, int pay, int debt, int min)
        {
            var check = 0;
            var rep = 0;
            min = debt / pay;
            while (check <= pay && rep <= debt)
            {
                if (check < pay)
                {
                    if (rep < debt)
                    {
                        if (check == --pay)
                        {
                            Console.WriteLine("This is the last payment.Debt:{0}", debt - rep);
                        }
                        Console.WriteLine("Enter sum payment");
                        sum = int.Parse(Console.ReadLine());
                        check++;
                        rep += sum;
                        
                        if (sum < min)
                        {
                            Console.WriteLine("Value less than minimum payment. Debt: {0}", debt - rep);
                        }
                        else
                        {
                            Console.WriteLine("Values ​​greater than the minimum contribution. Debt: {0}", debt - rep);
                            Console.WriteLine("Overpayment {0}", sum - min);
                        }

                    }
                    else
                    {
                        Console.WriteLine("Loan repaid for {0} payments", check);
                        Console.WriteLine("Overpayment {0}", rep - debt);
                        break;

                    }
                } 
               
            }
            
        }
        static void Main()
        {
            Console.WriteLine("Enter bank debt: ");
            var debt = int.Parse(Console.ReadLine());
            var sum = 0;
            Console.WriteLine("Enter the number of payments:");
            var pay = int.Parse(Console.ReadLine());
            var min = 0;
            Bank(sum,pay,debt,min);
            Console.ReadKey();
        }
    }
}
