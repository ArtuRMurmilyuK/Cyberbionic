using System;
using System.Reflection.Emit;

namespace L4TASK1
{
    class Program
    {
        static void Main()
        {
            
           
            /*Console.WriteLine("Enter value for operand 1: ");
            string enterO1 = Console.ReadLine();
           bool operand1 = double.TryParse(enterO1, out operand1);
           Convert.ToDouble(operand1);
            Console.WriteLine("Enter value for operand 2: ");
            operand2 = Convert.ToDouble(Console.ReadLine());
            */
            double operand1, operand2;
            Console.WriteLine("Введите число 1:");
            string input = Console.ReadLine();
            bool result = double.TryParse(input, out operand1);
            if (result == true)
            {
                Console.WriteLine("Преобразование прошло успешно");
                Console.WriteLine("Введите число 2:");
                string input2 = Console.ReadLine();
                bool result2 = double.TryParse(input, out operand2);

                if (result2 ==true)
                {
                    Console.WriteLine("Enter the sign for the arithmetic action: ");
                    string sing = Console.ReadLine();

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

                        default:
                        {
                            Console.WriteLine("Error\nArithmetic operation wrong");
                            break;
                        }
                    }
                }
                else
                    Console.WriteLine("Преобразование завершилось неудачно");
                Console.ReadKey();
            }
        }
    }
}
