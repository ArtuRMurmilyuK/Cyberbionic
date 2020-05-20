using System;

namespace L4TASK1
{
    class Program
    {
        static void Main()
        {
            double operand1, operand2;
           
            Console.WriteLine("Enter value for operand 1: ");
            operand1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for operand 2: ");
            operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the sign for the arithmetic action: ");
             string sing = Convert.ToString(Console.ReadLine());

             switch (sing)
             {
                 case "+":
                 {
                     Console.WriteLine("sum= " + (operand1 + operand2));
                     Console.ReadKey();
                     break;
                 }

                 case "-":
                 {
                     Console.WriteLine("subtraction = " + (operand1 - operand2));
                     Console.ReadKey();
                     break;
                 }

                 case "*":
                 {
                     Console.WriteLine("multiplication = " + (operand1 * operand2));
                     Console.ReadKey();
                     break;
                 }

                 case "/":
                 {
                     if (operand2 == 0) 
                     {
                         Console.WriteLine("ERROR\ncannot be divided by 0 ");
                         Console.ReadKey();
                     }

                     Console.WriteLine("division = " + (operand1 / operand2));
                     Console.ReadKey();
                     break;
                 }

                 case "%":
                 {
                     if (operand2 == 0)
                     {
                         Console.WriteLine("ERROR\ncannot be divided by 0 ");
                         Console.ReadKey();
                     }

                     Console.WriteLine("remainder of the division = " + (operand1 % operand2));
                     Console.ReadKey();
                     break;
                 }
            }
        }
    }
}
