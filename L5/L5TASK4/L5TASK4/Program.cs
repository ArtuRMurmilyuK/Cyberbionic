using System;

namespace L5TASK4
{
    class Program
    {
        static void Main()
        {
            //A | B = !( !A & !B)  
            bool A = true;
            bool B = false;

            // before applying the theorem
            if (A | B)
            {
                Console.WriteLine("A | B = {0}", A | B);
            }
            else
            {
                Console.WriteLine("A | B = {0}", A | B);
            }

            // After applying the theorem
            if (!(!A & !B))
            {
                Console.WriteLine("!(!A & !B) = {0}", !(!A & !B));
            }
            else
            {
                Console.WriteLine("!(!A & !B) = {0}", !(!A & !B));
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
