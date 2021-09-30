using System;

namespace ConvertLbApp
{
    public class Convector
    {
        public float Lb(float money)
        {
            return (float) Math.Round(money/MathLib.OneLb, 2);
        }

        public float Franc(float money)
        {
            return (float)Math.Round(money / MathLib.OneFrank, 2);
        }

        public float DeutscheMark(float money)
        {
            return (float)Math.Round(money / MathLib.OneMark, 2);
        }

        public float Yen(float money)
        {
            return (float)Math.Round(money / MathLib.OneYen, 2);
        }
    }
}