using System;

namespace CarCollection
{
    class Program
    {
        static void Main()
        {
            var collection = new CarCollection<string>();

            collection.AddCar("Toyota", new DateTime(2009, 12,5));
            collection.AddCar("Audi", new DateTime(2009, 12,5)); 
            collection.AddCar("BMW", new DateTime(2009, 12,5));

            collection.ShowCar();

            collection.CarCound();

            collection.ClearCar();

            collection.ShowCar();
        }
    }
}
