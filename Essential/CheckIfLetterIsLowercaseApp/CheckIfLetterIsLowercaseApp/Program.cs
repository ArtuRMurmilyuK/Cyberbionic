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
        public bool Check(char ch)
        {
            var res = Letter.IsLower(ch) ;
            return res;
        }
    }

    public static class Letter
    {
        public static bool IsLower(this char ch)
        {
            return Char.IsLower(ch);
        }
    }
}
