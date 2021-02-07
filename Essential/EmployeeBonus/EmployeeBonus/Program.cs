using System;

namespace EmployeeBonus
{
    public enum Post  
    {
        Secretary = 160,
        Mechanics = 100,
        Booker = 128
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Accauntant.Bonus());
        }
    }
}
