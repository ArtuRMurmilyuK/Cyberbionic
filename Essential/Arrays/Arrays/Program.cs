using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[]
            {
                1, 5, 7
            };
            var array2 = new int[]
            {
                2, 3, 8, 9
            };

            int[] array3 = new int[array1.Length + array2.Length];

            for (int i = 0, a1Index = 0, a2Index = 0; i < array3.Length; i++)
            {
                if (a1Index < array1.Length && array1[a1Index] < array2[a2Index]   )
                {
                    array3[i] = array1[a1Index++];

                    continue;
                }

                array3[i] = array2[a2Index++];
            }

            Console.ReadKey();
        }
    }
}
