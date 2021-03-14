using System;
using CarParkApp.Model;

namespace CarParkApp
{
    class Program
    {
        static void Main()
        {
            var carCollection = new CarCollection();
            
            carCollection.AddConsoleCar("BMW", 2010);
            carCollection.AddConsoleCar("Audi", 2016);
            carCollection.AddConsoleCar("Toyota", 2009);

            foreach (var i in carCollection)
            {
                Console.WriteLine(i);
            }
        }
    }
}
