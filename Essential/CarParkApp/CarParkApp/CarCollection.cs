using System.Collections;
using CarParkApp.Model;

namespace CarParkApp
{
    public class CarCollection : MyList<Car>
    {
        public void AddCar(string name, int year)
        {
            Add(new Car{Name = name, Year = year});
        }
        public void AddConsoleCar(string name, int year)
        {
            Add(new ConsoleCar{Name = name, Year = year});
        }
    }
}