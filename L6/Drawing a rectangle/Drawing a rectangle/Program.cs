using System;

namespace Drawing_a_rectangle
{
    class Program
    {
        static void Main()
        {
            int height= 0, width = 0;
            bool check;

            do
            {
                Console.WriteLine("Enter height:");
                string heightString = Console.ReadLine();
                check = int.TryParse(heightString, out height);
                Console.WriteLine("Enter width:");
                string widthString = Console.ReadLine();
                check = int.TryParse(widthString, out width);
            } while (check == false);

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
