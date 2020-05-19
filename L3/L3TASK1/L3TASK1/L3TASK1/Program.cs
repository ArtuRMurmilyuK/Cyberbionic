using System;

namespace L3TASK1
{
    class Program
    {
        static void Main()
        {

            {
                int x = 10, y = 12, z = 3;
                Console.WriteLine(x += y - x++ * z);//10+12-10*3=22-30=-8
            }


            {
                int x = 10, y = 12, z = 3;
                Console.WriteLine(z = --x - y * 5);//9-12*5=9-60
            }

            {
                int x = 10, y = 12, z = 3;
                Console.WriteLine(y /= x + 5 % z);//12/12=1
            }

            {
                int x = 10, y = 12, z = 3;
                Console.WriteLine(z = x++ + y * 5);//10 + 60 = 70
            }

            {
                int x = 10, y = 12, z = 3;
                Console.WriteLine(x = y - x++ * z);//12 - 30=-18
            }
            
            Console.ReadKey();

        }
    }
}
