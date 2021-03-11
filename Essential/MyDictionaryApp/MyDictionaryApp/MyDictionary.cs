using System;

namespace MyDictionaryApp
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] _keys;
        private TValue[] _values;
        private int Length => _keys.Length;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];
        }

        

        public void Add(TKey keys, TValue values)
        {
            TKey[] newKeys = new TKey[_keys.Length+1];

            for (int i = 0; i < _keys.Length; i++)
            {
                newKeys[i] = _keys[i];
            }

            newKeys[_keys.Length] = keys;
            _keys = newKeys;

            TValue[] newValue = new TValue[_values.Length+1];

            for (int i = 0; i < _values.Length; i++)
            {
                newValue[i] = _values[i];
            }

            newValue[_values.Length] = values;
            _values = newValue;
        }

        public void Show()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine($"{_keys[i]} - {_values[i]}");
            }
        }

        public int Count()
        {
            return Length;
        }

        public void IndexTKay(int a)
        {
            Console.WriteLine(_keys[a]);
        }
        public void IndexTValue(int a)
        {
            Console.WriteLine(_values[a]);
        }
    }
}