namespace ConvHalonsToFeet
{
    public class Convector
    {
        private const double OneFoot = 7.481;

        public double GallonToFoot(in int gallon)
        {
            return gallon / OneFoot;
        }
    }
}