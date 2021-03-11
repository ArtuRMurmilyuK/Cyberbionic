using System;

namespace MyDictionaryApp
{
    class Program
    {
        static void Main()
        {
            MyDictionary<int,string> dictionary = new MyDictionary<int, string>();
            
            dictionary.Add(2,"Maks");
            dictionary.Add(3,"Artur");

            dictionary.Show();

            Console.WriteLine(dictionary.Count());

            dictionary.IndexTKay(0);
            dictionary.IndexTValue(1);
        }
    }
}
