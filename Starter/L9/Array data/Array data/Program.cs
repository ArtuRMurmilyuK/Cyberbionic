using System;

namespace Array_data
{
    class Program
    {
        static void Main()
        {
            var stringN = Console.ReadLine();
            if (int.TryParse(stringN, out int N))
            {


                int[] array = new int[N];
                var max = 0;
                var sum = 0;
                var min = 0;
                var odd = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    sum += array[i];
                    //Max
                    if (max <= array[i])
                    {
                        max = array[i];
                    }

                    //min
                    if (min >= array[i])
                    {
                        min = array[i];
                    }

                    //odd
                    if (array[i] % 2 != 0)
                    {
                        Console.WriteLine("odd numbers: " + array[i]);
                    }

                }

                var average = (double) sum / N;
                Console.WriteLine("MaxValue: {0}", max);
                Console.WriteLine("MinValue: {0}", min);
                Console.WriteLine("Sum: {0}", sum);
                Console.WriteLine("Average: {0}", average);
                Console.ReadKey();
            }
        }
    }
}
