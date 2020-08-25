using System;

namespace NDS
{
    class Program
    {
        static void Main()
        {
            Invoice invoice = new Invoice();
            invoice.Init(0, " ", " ");
            
            Console.ReadLine();
        }
    }
}
