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
            else
            {
                return 0;
            }
        }

        static void Main()
        {
            int a = 0, b = 0;
            Console.WriteLine("Enter value a:");

            string stringA = Console.ReadLine();
            bool checkA = Int32.TryParse(stringA, out a);
            if (checkA == true)
            {
                Console.WriteLine("Enter value b:");

                string stringB = Console.ReadLine();
                bool checkB = Int32.TryParse(stringB, out b);
                if (checkB == true)
                {
                    Console.WriteLine("Enter arithmetic operation:");
                    string act = Console.ReadLine();
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

                    Console.WriteLine(result);
                    Console.ReadKey();
                }
            }
        }
    }
}
