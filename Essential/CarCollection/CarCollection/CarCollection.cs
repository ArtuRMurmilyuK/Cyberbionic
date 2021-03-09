using System;

namespace CarCollection
{
    public class CarCollection<T> : MyList<T>
    {
        private readonly MyList<string> carName;
        private readonly MyList<DateTime> carYear;

        public CarCollection()
        {
            carName = new MyList<string>();
            carYear = new MyList<DateTime>();
        }

        public void AddCar(string name, DateTime year)
        {
            carName.Add(name);
            carYear.Add(year);
        }
        public void ShowCar()
        {
            carName.Show();
            carYear.Show();
        }
        
        public void ClearCar()
        {
            carName.Clear();
            carYear.Clear();
        }

        public void CarCound()
        {
            Console.WriteLine(carName.Count);
        }
    }
}