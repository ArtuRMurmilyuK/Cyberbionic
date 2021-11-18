using System;

namespace MyListApp
{
    public class MyList<T>
    {
        T[] _array;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T element)
        {
            T[] newArr = new T[_array.Length + 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                if (i < _array.Length)
                {
                    newArr[i] = _array[i];
                }
                else
                {
                    newArr[i] = element;
                }
            }
            _array = newArr;
        }

        public void Show()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }

        public void Insert(int index, T element)
        {
            T[] newArr = new T[_array.Length + 1];
            
            for (int i = 0; i < newArr.Length; i++)
            {
                T k = _array[index];
                if (i == index)
                {
                    newArr[i] = element;
                }
                else if(i   > index)
                {
                    newArr[i] = k;
                    index++;
                }
                else
                {
                    newArr[i] = _array[i];
                }
            }
            _array = newArr;
        }
    }
}
