using System;

namespace The_conclusion_is_the_opposite
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            for (int i = 9; i <= array.Length ; i--)
            {
                Console.WriteLine(array[i]);
                if (i == 0) break;
            }

            Console.ReadKey();
        }
    }
}
