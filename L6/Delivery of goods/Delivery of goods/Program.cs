using System;

namespace Delivery_of_goods
{
    class Program
    {
        static void Main()
        {
            bool check = false;
            int N;
            
            do
            {
                Console.WriteLine("Enter number of clients:");
                string clients = Console.ReadLine();
                check = int.TryParse(clients, out N);
            } while (check == false);

            var sum=1;
            do
            {
                 sum*= N;
                 N--;
            } while (N>0);
            Console.WriteLine("Number of routes: " + sum);
            Console.ReadKey();
        }
    }
}
