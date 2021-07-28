using System;
using System.Linq;
using System.Text;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
          Build();
          BuildElevator();
          Build();
          Build();
        }

        static void Build()
        {
            var build = new Floor();

            build.CeilingAndFloor();
            build.Walls();
            build.Walls();
            build.Walls();
            build.Walls();
            build.Walls();
            build.CeilingAndFloor();
        }
        static void BuildElevator()
        {
            var build = new Elevator();

            build.CeilingAndFloor();
            build.Walls();
            build.Walls();
            build.Walls();
            build.Walls();
            build.Walls();
            build.CeilingAndFloor();
        }
    }

    class Floor
    {
        StringBuilder sbCeiling = new StringBuilder("**********");

        public void CeilingAndFloor()
        {
             Console.Write(sbCeiling.ToString());
             
             Console.WriteLine();
        }

        public void Walls()
        {
            StringBuilder sbWalls = new StringBuilder("*        *");
            
            Console.Write(sbWalls.ToString());
            Console.WriteLine();
        }
    }

    class Elevator
    {
        StringBuilder sb = new StringBuilder();
        public void CeilingAndFloor()
        {
            Console.Write(' ');
            for (int i = 0; i < 8; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }

        public void Walls()
        {
            Console.Write(' ');
            for (int i = 0; i < 8; i++)
            {

                if (i == 0 || i == 7)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}
