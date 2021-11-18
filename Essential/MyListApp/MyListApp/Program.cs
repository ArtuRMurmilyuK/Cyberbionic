using System;

namespace MyListApp
{
    class Program
    {
        static void Main()
        {
            MyList<int> list = new MyList<int>();
            
            list.Add(2);
            list.Add(3); 
            list.Add(4);
            list.Add(5);
            
            list.Show();
            
            list.Insert(0, 99);
            list.Insert(2, 22);
            
            list.Show();

            Console.ReadKey();
        }
    }
}
