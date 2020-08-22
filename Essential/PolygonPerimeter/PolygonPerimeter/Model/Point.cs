namespace PolygonPerimeter.Model
{
    public class Point
    {
        public Point(in int x, in int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public int X { get; }

        public int Y { get; }

        public string Name { get; }
    }
}
