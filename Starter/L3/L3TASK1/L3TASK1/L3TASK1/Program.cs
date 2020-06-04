using System;

namespace L3TASK1
{
    class Program
    {
        static void Main()
        {

            {
                int x = 10, y = 12, z = 3, resultX1;
                resultX1 = x += y - x++ * z;//10+12-10*3=22-30=-8
                Console.WriteLine(resultX1);
                Console.WriteLine(resultX1 + 1);//Result with x++
            }


            {
                int x = 10, y = 12, z = 3, resultZ1;
                resultZ1= z = --x - y * 5;//9-12*5=9-60=51
                Console.WriteLine(resultZ1);
            }

            {
                int x = 10, y = 12, z = 3, resultY;
                resultY = y /= x + 5 % z;//if 12/(10+2) = 1 or 12/10 + 5%3 = 3
                Console.WriteLine(resultY);
            }

            {
                int x = 10, y = 12, z = 3, resultZ2;
                resultZ2 = z = x++ + y * 5;//10 + 60 = 70
                Console.WriteLine(resultZ2);
                Console.WriteLine(resultZ2 +1);//with x++
            }

            {
                int x = 10, y = 12, z = 3, resultX2;
                resultX2 = x = y - x++ * z;//12 - 30=-18
                Console.WriteLine(resultX2);
                Console.WriteLine(resultX2 + 1);//With x++
            }
            
            Console.ReadKey();

        }
    }
}
