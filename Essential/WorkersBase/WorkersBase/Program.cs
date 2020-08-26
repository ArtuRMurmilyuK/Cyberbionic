using System;

namespace WorkersBase
{
    class Program
    {
        static void Main()
        {
            var bases = new Base();

            bases.Add(new Workers("Petrov V.O.", "cleaner","200",2));
            bases.Add(new Workers("Morozov I.M.", "chef", "500",2));
            bases.Add(new Workers("Makar S.O.", "security", "350",2));

            Console.WriteLine(bases.GetInvoice());
            bases.Remove("Petrov V.O.");
            Console.WriteLine(bases.GetInvoice());
            Console.ReadLine();
        }
    }
}
