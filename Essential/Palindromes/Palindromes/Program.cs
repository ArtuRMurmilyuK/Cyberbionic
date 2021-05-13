using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hoursString = new string[25];

            for (int i = 0; i < 24; i++)
            {
                var moreTen = i < 10 ? ("0" + i).ToString() : i.ToString();

                if (Int32.Parse(moreTen) >= 6 && Int32.Parse(moreTen) < 10 || 
                    Int32.Parse(moreTen) >= 16 && Int32.Parse(moreTen) < 20)
                {
                    continue;
                }

                hoursString[i] = moreTen + ':' + moreTen[1]+moreTen[0];
                Console.WriteLine(hoursString[i]);
            }
        }
    }
}
