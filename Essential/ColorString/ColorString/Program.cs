using System;

namespace ColorString
{
    enum Color
    {
        Red = 1,
        Yellow = 2,
        Green = 3,
        Blue = 4 
    }

    static class Fill
    {
        public static void Print(string stroka, int color)
        {
            if (color == (int) Color.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if(color == (int)Color.Yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (color == (int) Color.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
        }

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string stroka = Console.ReadLine();

            Console.WriteLine("Red = 1, Yellow = 2, Green = 3, Blue = 4 ");
            int color = Int32.Parse(Console.ReadLine());

            Fill.Print(stroka, color);

            Console.WriteLine(stroka);
        }
    }
}
