using System;
using System.Collections.Generic;

namespace ServisApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var servise = new Servise();

            servise.AddStudent("Anton", 18, 1, "IPZ");
            servise.AddStudent("Artur", 18, 2, "IPZ");
            servise.AddStudent("Stas", 19, 2, "KN");
            servise.AddStudent("Stas", 25, 3, "Manager");

            servise.DisplayAll();
            servise.DisplayAge(17,20);
            servise.DisplayCourse(2,"IPZ");

            servise.DeleteByName("Artur");
            servise.DisplayAll();
        }
    }
}
