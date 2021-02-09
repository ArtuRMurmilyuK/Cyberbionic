using System;

namespace ArrayOfDelegates
{
    class Program
    {
        public delegate int Average(int [] array);
        static void Main()
        {
            Console.WriteLine(AverageDelegate());
        }

        public static int AverageDelegate()
        {
            Average average = delegate (int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum / array.Length;
            };

            int mid = average(new [] {22,2,3,5});

            return mid;
        }
    }
}
