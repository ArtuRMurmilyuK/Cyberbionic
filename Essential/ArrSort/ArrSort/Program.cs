using System;

namespace ArrSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 3, 5, 7, 2, 0, 1, 2,6,5,8,23,77};

            array.SortUp();
            foreach (var numb in array)
            {
                Console.Write(numb + " ");
            }
        }
    }
}
