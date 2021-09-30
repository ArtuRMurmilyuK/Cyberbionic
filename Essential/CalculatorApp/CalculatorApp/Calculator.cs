namespace CalculatorApp
{
    public class Calculator
    {
        private readonly IConsole _console;

        public Calculator(IConsole console)
        {
            _console = console;
        }

        public void Mul(int num)
        {
            for (int i = 0, k = num; i < 30; i++)
            {
                if (i == 9 || i == 19)
                {
                    _console.WriteLine(num);
                }
                else
                {
                    _console.Write(num);
                }
                num += k;
            }
        }
    }
}