using System;

namespace L3TASK3
{
    class Program
    {
        static void Main()
        {
            const double pi = 3.1415926535897931;
            float r, area;
            r = Convert.ToSingle(Console.ReadLine());
            area = (float) (pi * Math.Pow(r, 2));
            Console.WriteLine(area);
            Console.ReadKey();

        }
    }
}
