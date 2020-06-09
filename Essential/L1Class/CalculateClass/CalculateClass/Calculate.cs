using System;
using System.Runtime.InteropServices.ComTypes;

namespace CalculateClass
{
    public class Calculate
    {
        public int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int Mul(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Div(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
    }
}