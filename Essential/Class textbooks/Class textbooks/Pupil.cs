using System;
using System.Collections.Generic;

namespace Class_textbooks
{
    class Pupil
    { 
        List<string> listOfPeople = new List<string>()
        {
            "Mike",
            "Oleg",
            "Nik",
            "Pedro"
        };
        
        protected void Study()
        {
            Console.WriteLine("{0}" + " study: ", listOfPeople[0]);
            Console.WriteLine("{0}" + " study: ", listOfPeople[1]);
            Console.WriteLine("{0}" + " study: ", listOfPeople[2]);
            Console.WriteLine("{0}" + " study: ", listOfPeople[3]);
        }

        protected void Read()
        {
            Console.WriteLine("{0}" + " read: ", listOfPeople[0]);
            Console.WriteLine("{0}" + " read: ", listOfPeople[1]);
            Console.WriteLine("{0}" + " read: ", listOfPeople[2]);
            Console.WriteLine("{0}" + " read: ", listOfPeople[3]);
        }

        protected void Write()
        {
            Console.WriteLine("{0}" + " write: ", listOfPeople[0]);
            Console.WriteLine("{0}" + " write: ", listOfPeople[1]);
            Console.WriteLine("{0}" + " write: ", listOfPeople[2]);
            Console.WriteLine("{0}" + " write: ", listOfPeople[3]);
        }

        protected void Relax()
        {
            Console.WriteLine("{0}" + " relax: ", listOfPeople[0]);
            Console.WriteLine("{0}" + " relax: ", listOfPeople[1]);
            Console.WriteLine("{0}" + " relax: ", listOfPeople[2]);
            Console.WriteLine("{0}" + " relax: ", listOfPeople[3]);
        }
    }
}
