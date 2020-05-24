using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

namespace Four_Metods
{
    class Program
    {
        static void Add(int a, int b, ref int sum)
        {
             sum = a + b;
        }

        static void Sub(int a, int b, ref int sub)
        {
            sub = a - b;
        }

        static void Mul(int a, int b, ref int mul)
        {
            mul = a * b;
        }

        static void Div(int a, int b, ref int div)
        {
            if (b != 0)
            {
                div = a / b;
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter value a:");

            string stringA = Console.ReadLine();
            int valueA = Int32.Parse(stringA);

            Console.WriteLine("Enter value b:");

            string stringB = Console.ReadLine();
            int valueB = Int32.Parse(stringB);

            Console.WriteLine("Enter arithmetic operation:");
            string act = Console.ReadLine();
            switch (act)
            {
                case "+":
                {
                    int sum = 0;

                    Add(valueA, valueB, ref sum);

                    Console.WriteLine("{0} + {1} = {2}", valueA, valueB, sum);

                    break;
                }

                case "-":
                {
                    int sub = 0;

                    Sub(valueA, valueB, ref sub);

                    Console.WriteLine("{0} - {1} = {2}", valueA, valueB, sub);

                    break;
                }

                case "*":
                {
                    int mul = 0;

                    Mul(valueA, valueB, ref mul);

                    Console.WriteLine("{0} * {1} = {2}", valueA, valueB, mul);

                    break;
                }

                case "/":
                {
                    int div = 0;

                    Div(valueA, valueB, ref div);
                    if (valueB != 0)
                    {
                        Console.WriteLine("{0} / {1} = {2}", valueA, valueB, div);
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
            
            Console.ReadKey();
        }
    }
}
