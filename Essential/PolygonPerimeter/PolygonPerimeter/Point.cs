using System;

namespace PolygonPerimeter
{
    class Point
    {
        private int x, y;
        private string name;

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public string Name
        {
            get { return name; }
        }

        //Пользовательский конструктор
        public Point(int x, int y, string name)
        {
            Console.WriteLine("Enter X: ");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            this.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            this.name = Console.ReadLine();
        }
    }
}
