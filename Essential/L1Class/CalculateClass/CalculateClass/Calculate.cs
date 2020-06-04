namespace CalculateClass
{
    public class Calculate
    {
        private  int _firstNumber;
        private  int _secondNumber;

        public int FirstNumber
        {
            set
            {
                _firstNumber = value;
            }//Write

            get
            {
                return _firstNumber;
            }//READ
        }

        public int SecondNumber
        {
            set
            {
                _secondNumber = value;
            }

            get
            {
                return _secondNumber;
            }
        }

        public Calculate(int firstNumber, int secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        
        public int Add()
        {
            return _firstNumber + _secondNumber;
        }

        public int Mul()
        {
            return _firstNumber * _secondNumber;
        }

        public int Odd()
        {
            return _firstNumber / _secondNumber;
        }

        public int Sub()
        {
            return _firstNumber - _secondNumber;
        }
    }
}