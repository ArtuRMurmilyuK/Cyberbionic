using System;
using SumOfFractionsApp.Models;

namespace SumOfFractionsApp
{
    public class Convector
    {
        public Fraction StringToFraction(string str)
        {
            string[] newSting = str.Split(new char[] { '/' });
            int[] array = {Convert.ToInt32(newSting[0]), Convert.ToInt32(newSting[1])};

            return new Fraction(array[0], array[1]);
        }
    }
}