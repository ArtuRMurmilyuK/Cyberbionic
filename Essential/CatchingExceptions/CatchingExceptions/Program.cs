using System;

namespace CatchingExceptions
{
    class Program
    {
        static void Main()
        {
           EnterNumb();
        }

        static void EnterNumb()
        {
            try
            {
                Console.Write("Enter x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter y: ");
                int y = int.Parse(Console.ReadLine());

                int result = MyDel(x, y);
                Console.WriteLine("Result: " + result);
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Div on 0 detected!");
                Main();
            }
            catch (FormatException)
            {
                Console.WriteLine("this is not a number");
                Main();
            }
        }

        static int MyDel( int x,  int y)
        {
            return x / y;
        }
    }
}
