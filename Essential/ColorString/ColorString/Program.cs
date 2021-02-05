using System;

namespace ColorString
{
    enum Color: int
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
            switch (color)
            {
                case 1:
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                }
                case 2:
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                }
                case 3:
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }
                case 4:
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                }
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
