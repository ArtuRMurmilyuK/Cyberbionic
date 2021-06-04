using System;
using System.Collections.Generic;

namespace TopList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            LargestX(3, new List<int>{12,9,5,4,3,0});
        }

        public static List<int> LargestX(int a, List<int> array)
        {
            List<int> newArray = new List<int>();
            for (int i = array.Count - 1; i >= 0; i--)
            {
                if (i < a)
                {
                    newArray.Add(array[i]);
                }
                
            }

            return newArray;
        }
    }
}
