using System;

namespace CatchingExceptions
{
    class Program
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            
            ExceptionMyDel(x,y);
            
        }

        public static void ExceptionMyDel(int x , int y)
        {
            try
            {
                Console.WriteLine(MyDel(x, y));
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Div on 0 detected!");
            }
            catch (FormatException)
            {
                Console.WriteLine("this is not a number");
            }
        }

        static int MyDel( int x,  int y)
        {
            return x / y;
        }
    }
}
