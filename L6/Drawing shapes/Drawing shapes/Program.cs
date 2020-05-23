using System;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography.X509Certificates;

namespace Drawing_shapes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("select shape: rectangle, right triangle, equilateral triangle, rhombus");
            var figure = Console.ReadLine();
            switch (figure)
            {
                case ("rectangle"):
                {
                    for (int n = 0; n < 5; n++)
                    {
                        for (int m = 0; m < 10; m++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                case ("right triangle"):
                {
                    for (int i = 0; i <10; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                           Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
                case ("3"): //requilateral triangle
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            for (int j = 0, p = 20; j < i && p > j; j++, p--)
                            {
                                if (p <= i)
                                {
                                    Console.Write("*");
                                }
                                Console.Write(" ");
                            }

                            Console.WriteLine("");
                        }
                       

                        break;
                }

                case ("4"): //rhombus
                    {
                        for (var i = 0; i < 10; i++)
                        {
                            for (int j = 5; j < i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 5; j > i; j--)
                            {

                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        break;
                }
            }
        }
    }
}
