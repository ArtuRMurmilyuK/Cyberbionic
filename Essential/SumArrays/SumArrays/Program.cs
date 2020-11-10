using System;
using System.Linq;

namespace SumArrays
{
    class Program
    {
        static void Main()
        {
            int[] arrays = {1, 2, 3, 4, 5};

            var max = arrays.Max();
            var min = arrays.Min();
            var sum = arrays.Sum();
            var mid = arrays.Sum() / arrays.Length;

            Console.WriteLine($"Min: {min} Max: {max} Sum: {sum} Mid:{mid}");

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < arrays.Length; i++)
            {
                if (arrays[i] % 2 != 0)
                {
                    Console.WriteLine(arrays[i]);
                }
            }
        }
    }
}
