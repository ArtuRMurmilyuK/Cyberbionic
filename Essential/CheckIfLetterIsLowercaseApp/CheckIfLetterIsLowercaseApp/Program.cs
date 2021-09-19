using System;

namespace CheckIfLetterIsLowercaseApp
{
    class Program
    {
        static void Main()
        {
        }
    }

    public class IsLowerSample
    {
        public int Check(in char ch)
        {
            if (Char.IsLower(ch) == true) 
            {
                return 1;
            }

            return 0;
        }
    }
}
