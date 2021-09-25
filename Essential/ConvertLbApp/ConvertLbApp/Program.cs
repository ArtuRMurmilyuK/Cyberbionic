using System;

namespace ConvertLbApp
{
    class Program
    {
        static void Main()
        {
        }
    }

    public class Convector
    {
        public float Lb(float money)
        {
            const float oneLb = 1.487f;
            return (float) Math.Round(money/oneLb, 2);
        }

        public float Franc(float money)
        {
            const float oneFrank = 0.172f;
            return (float)Math.Round(money / oneFrank, 2);
        }

        public float DeutscheMark(float money)
        {
            const float oneMark = 0.584f;
            return (float)Math.Round(money / oneMark, 2);
        }

        public float Yen(float money)
        {
            const float oneYen = 0.00955f;
            return (float)Math.Round(money / oneYen, 2);
        }
    }
}
