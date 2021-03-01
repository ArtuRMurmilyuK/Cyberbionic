using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivan";

            name.SayBy();
            ExtensionClass.SayBy("Ann");
        }
    }

    public static class ExtensionClass
    {
        public static void SayBy(this string s)
        {
            Console.WriteLine($"{s}, By!");
        }
    }
}
