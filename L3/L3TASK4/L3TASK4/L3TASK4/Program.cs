using System;
using System.Runtime.Remoting.Services;

namespace L3TASK4
{
    class Program
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter a:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;
            Console.WriteLine("sum:" + sum);

            int sub = a - b;//subtraction
            Console.WriteLine("subtraction:" +sub);

            int mul = a * b; //multiplication
            Console.WriteLine("multiplication:" +mul);

            int div = a / b; //division
            Console.WriteLine("division:" + div);

            int rem = a % b; //remainder of integer division
            Console.WriteLine("remainder of integer division: " + rem);

            int inc = ++a ; //Increment operation
            Console.WriteLine("increment operation(++): " + inc +", "+ (++b));

            int incm = --a; //Increment operation minus
            Console.WriteLine("increment operation(--): " + incm + ", " + (--b));

            Console.ReadKey();
        }
    }
}
