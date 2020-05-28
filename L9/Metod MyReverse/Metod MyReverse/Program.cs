using System;

namespace Metod_MyReverse
{
    class Program
    {
        static void MyReverse(int[] array,  int n)
        {
            int[] modArray = new int[array.Length];
            for (int i = 0; i <= array.Length; i++)
            {
                n--;
                modArray[i] = array[n];
                Console.WriteLine( modArray[i] );
                if (n == 0)
                {
                    break;
                }
            }
            modArray = array;
        }
        static int [] SubArray(int[] array, int index, int count)
        {
           
            int [] modArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                if (modArray[i] >= array.Length - index)
                {
                    modArray[i] = 1;
                }
                else
                {
                    modArray[i] = array[index];//1,2,3,4,5
                }
                index++;
                Console.WriteLine(modArray[i]);
            }
            modArray = array;
            return array;
        }
        static void Main()
        {
            Console.WriteLine("Enter N");
            var stringN = Console.ReadLine();
            if (int.TryParse(stringN, out int n))
            {
                    int[] array = new int[n];

                    for (int i = 0; i < array.Length; i++)
                    {
                        var stringArray = Console.ReadLine();
                        if (int.TryParse(stringArray, out array[i])) ;
                    }

                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine(array[i]);
                    }

                    Console.WriteLine("Enter index:");
                    var stringIndex = Console.ReadLine();
                    if (int.TryParse(stringIndex, out int index))
                    {
                        Console.WriteLine("Enter count");
                        var stringCount = Console.ReadLine();
                        if (int.TryParse(stringCount, out int count))
                        {
                            MyReverse(array, n);
                            SubArray(array, index, count);
                        }
                    }
            }
            Console.ReadKey();
        }
    }
}
