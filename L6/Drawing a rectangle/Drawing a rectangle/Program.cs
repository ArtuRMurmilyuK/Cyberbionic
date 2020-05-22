using System;

namespace Drawing_a_rectangle
{
    class Program
    {
        static void Main()
        {
            bool check = false;

            int I= 0, J = 0;
            do
            {
                Console.WriteLine("Enter width:");
                string i = Console.ReadLine();
                check = int.TryParse(i, out I);
                Console.WriteLine("Enter width:");
                string j = Console.ReadLine();
                check = int.TryParse(j, out J);
            } while (check == false);

            int n = 0, m = 0;
            for (n = 0; n < I; n++)
            {
                for (m = 0; m < J; m++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
