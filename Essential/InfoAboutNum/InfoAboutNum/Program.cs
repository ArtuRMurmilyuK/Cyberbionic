using System;

namespace InfoAboutNum
{
    class Program
    {
        static void Main()
        {
            var myList = new MyList<int>();
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);

            myList.RemoveByIndex(1);
            myList.RemoveByValue(6);

            for (int i = 0; i < myList.Length; i++)
            {
                Console.WriteLine(myList.GetElement(i));
            }

            myList.SearchFoIndex(0);
        }
    }

    public class MyList<T>
    {
        private T[] _array = new T[0];

        public int Length => _array.Length;

        public void Add(T arg)
        {
            T[] newArray = new T[_array.Length + 1];

            for (int i = 0; i < newArray.Length; i++)
            {
                if (_array.Length != i)
                {
                    newArray[i] = _array[i];

                    continue;
                }
                newArray[i] = arg;
            }
            _array = newArray;
        }

        public void SearchFoIndex(T index)
        {
            
            for (int i = 0; i < _array.Length; i++)
            {
                if (Equals(index, i))
                {
                    var result =  _array[i];
                    Console.WriteLine(result);
                }
            }
        }
        
        public T GetElement(int index)
        {
            return _array[index];
        }

        public void RemoveByIndex(int index)
        {
            T[] newArray = new T[_array.Length-1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = _array[i];
            }

            for (int i = index + 1; i < _array.Length; i++)
            {
                newArray[i - 1] = _array[i];
            }

            _array = newArray;
        }

        public void RemoveByValue(int value)
        {
            T[] newArray = new T[_array.Length - 1];

            for (int i = 0; i < _array.Length; i++)
            {
                if (!Equals(_array[i], value))
                {
                    newArray[i] = _array[i];
                }
            }
            _array = newArray;
        }
    }
}
