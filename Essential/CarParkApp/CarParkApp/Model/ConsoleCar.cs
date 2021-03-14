namespace CarParkApp.Model
{
    public class ConsoleCar : Car
    {
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Year)}: {Year}";
        }
    }
}