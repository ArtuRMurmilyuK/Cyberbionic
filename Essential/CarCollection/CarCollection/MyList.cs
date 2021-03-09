using System;

namespace CarCollection
{
    public class MyList<T>
    {
        private T[] array;
        public int Count => array.Length;
        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[array.Length] = a;
            array = tempArray;
        }

        public void Show()
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }

        public void Clear()
        {
            array = new T[0];
        }
    }
}