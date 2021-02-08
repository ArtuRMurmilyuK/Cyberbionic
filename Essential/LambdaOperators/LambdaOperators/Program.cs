using System;

namespace LambdaOperators
{
    public delegate int Operation(int a, int b);
    class Program
    {
        private static int Sum()
        {
            Operation sumOperation;
            sumOperation = (a, b) => a + b;

            int sumResult = sumOperation(2, 3);
            return sumResult;
        }

        private static int Sub()
        {
            Operation subOperation;
            subOperation = (a, b) => a - b;

            int subResult = subOperation(6, 2);

            return subResult;
        }

        private static int Div()
        {
            Operation divOperation;
            divOperation = (a, b) => 
            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                else
                {
                    return a / b;
                }
            };
            
            int divResult = divOperation (6, 2);

            return divResult;
        }
        private static int Mul()
        {
            Operation mulOperation;
            mulOperation = (a, b) => a * b;

            int mulResult = mulOperation(6, 2);

            return mulResult;
        }
        static void Main()
        {
            Console.WriteLine("Sum: {0}", Sum());
            Console.WriteLine("Sub: {0}", Sub());
            Console.WriteLine("Div: {0}", Div());
            Console.WriteLine("Mul: {0}", Mul());
        }
    }
}
