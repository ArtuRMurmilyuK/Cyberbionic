using System;

namespace Drawing_a_rectangle
{
    class Program
    {
        static void Main()
        {
            bool check = false;

            int height= 0, width = 0;
            do
            {
                Console.WriteLine("Enter height:");
                string i = Console.ReadLine();
                check = int.TryParse(i, out height);
                Console.WriteLine("Enter width:");
                string j = Console.ReadLine();
                check = int.TryParse(j, out width);
            } while (check);

            for (int n = 0; n < height; n++)
            {
                for (int m = 0; m < width; m++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
