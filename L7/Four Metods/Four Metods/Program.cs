using System;

namespace Four_Metods
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static int Mul(int a, int b)
        {
            return  a * b;
        }

        static int Div(int a, int b)
        {
            if (b != 0)
            {

                return a / b;
            }
            return 0;
            
        }

        static void Main()
        {
            var a=0;
            var b=0;
            Console.WriteLine("Enter value a:");

            var stringA = Console.ReadLine();
            
            var checkA = int.TryParse(stringA, out a);
            if (checkA)
            {
                Console.WriteLine("Enter value b:");

                var stringB = Console.ReadLine();
                var checkB = int.TryParse(stringB, out b);
                if (checkB)
                {
                    Console.WriteLine("Enter arithmetic operation:");
                    var act = Console.ReadLine();
                    var result = 0;
                    switch (act)
                    {
                        case "+":
                        {
                            result = Add(a, b);
                            break;
                        }

                        case "-":
                        {
                            result = Sub(a, b);
                            break;
                        }

                        case "*":
                        {
                            result = Mul(a, b);
                            break;
                        }

                        case "/":
                        {
                            if (b != 0)
                            {
                                result = Div(a, b);
                            }
                            else
                            {
                                Console.WriteLine("Error.\nYou cannot divide by zero");
                            }

                            break;
                        }

                        default:
                        {
                            Console.WriteLine("Incorrect arithmetic entered");
                            break;
                        }
                    }

                    Console.WriteLine("{0}" + "{1}" + "{2}=" + "{3}", a, act, b, result);
                    Console.ReadKey();
                }
            }
        }
    }
}
