using System;
using System.Collections.Generic;

namespace Array2
{
    class Program
    {
        static List<int> _evenNumbers = new List<int>();
        static List<int> _oddNumbers = new List<int>();
        static void Main(string[] args) // Результат: 2 массива, в одном четные числа из массивов,в  другом - нечет
        {
            int[] array1 = {1, 2, 4, 7, 9, 11, 12};

            int[] array2 = {3, 5, 6, 7, 8, 9, 10};

            int[] array3 = {2, 3, 6, 12, 13, 17, 18};

            Even(array1);
            Even(array2);
            Even(array3);

            Odd(array1);
            Odd(array2);
            Odd(array3);

            Console.ReadKey();
        }

        public static void Even(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    _evenNumbers.Add(array[i]);
                }
            }
        }

        public static void Odd(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    _oddNumbers.Add(array[i]);
                }
            }
        }
    }
}
