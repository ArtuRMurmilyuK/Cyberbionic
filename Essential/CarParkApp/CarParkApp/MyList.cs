using System;
using System.Collections;

namespace CarParkApp
{
    public class MyList<T> : IEnumerable
    {
        private T[] _array;

        public MyList()
        {
            _array = new T[0];
        }

        public int Count => _array.Length;

        public void Add(T a)
        {
            var tempArray = new T[_array.Length + 1];
            for (var i = 0; i < _array.Length; i++)
            {
                tempArray[i] = _array[i];
            }

            tempArray[_array.Length] = a;
            _array = tempArray;
        }

        public void Show()
        {
            foreach (var i in _array)
            {
                Console.WriteLine(i);
            }
        }

        public void Clear()
        {
            _array = new T[0];
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }
    }
}