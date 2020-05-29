using System;

namespace Increase_array_length
{
    class Program
    {
        static void AddValue(int[] array, int value)
        {
            var n = array.Length;
            Console.WriteLine("Enter Value for 0 index: ");
            var stringValue = Console.ReadLine();
            if (int.TryParse(stringValue, out value))
            {
                //Array increase
                Array.Resize<int>(ref array, array.Length + 1);
                for (int i = array.Length - 2; i >= 0 ; i--)
                {
                    array[i + 1] = array[i];
                }
                array[0] = value;
                //display 
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        static void Main()
        {
            int value = 0;
            Console.WriteLine("Enter N");
            var stringN = Console.ReadLine();
            if (int.TryParse(stringN, out int n))
            {
                int[] array = new int[n];

                for (int i = 0; i < array.Length; i++)
                {
                    var stringArray = Console.ReadLine();
                    if (int.TryParse(stringArray, out int arr))
                    {
                        array[i] = arr;
                    }
                }
                AddValue(array, value);
                Console.ReadKey();
            }
        }
    }
}
