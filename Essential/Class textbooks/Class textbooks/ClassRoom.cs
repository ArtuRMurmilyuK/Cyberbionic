using System;

namespace Class_textbooks
{
    class ClassRoom
    {
        static Random rnd = new Random();
        static readonly string[] Rating = {"Good", "Bad", "Excellent"};

        private int rIndex = rnd.Next(Rating.Length);

        
    }
}
