using System;
using System.Collections.Generic;

namespace CollectionWithYield
{
    internal class Program
    {
        static void Main()
        {
            int[] array = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            
            foreach (var i in Collection(array))
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> Collection(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
            }
        }
    }
}
