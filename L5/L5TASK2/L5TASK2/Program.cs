using System;

namespace L5TASK2
{
    class Program
    {
        static void Main()
        {
            {
                int x = 5, y = 10, z = 15;
                int result = x += y >> x++ * z; //5 * 15 = 75
                Console.WriteLine("Result x = " + result);
            }

            {
                int x = 5, y = 10, z = 15;
                int result = z = ++x & y * 5;
                Console.WriteLine("Result z = " + result);
            }

            {
                int x = 5, y = 10, z = 15;
                int result = y /= x + 5 | z;
                Console.WriteLine("Result y = " + result);
            }

            {
                int x = 5, y = 10, z = 15;
                int result = z = x++ & y * 5;
                Console.WriteLine("Result z = " + result);
            }

            {
                int x = 5, y = 10, z = 15;
                int result = x = y << x++ ^ z;
                Console.WriteLine("Result x = " + result);
                Console.ReadKey();
            }

        }
    }
}
