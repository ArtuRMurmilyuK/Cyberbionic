using System;

namespace L3TASK1
{
    class Program
    {
        static void Main()
        {

            int x=10, y=12, z=3;
            
            Console.WriteLine( x += y - x++ * z);
            Console.WriteLine(z = --x - y * 5);
            Console.WriteLine(y /= x + 5 % z);
            Console.WriteLine(z = x++ + y * 5);
            Console.WriteLine(x = y - x++ * z);
            Console.ReadKey();

        }
    }
}
