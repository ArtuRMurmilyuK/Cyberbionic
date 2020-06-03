namespace CalculateClass
{
    public class Calculate
    {
        private  int _firstNumber;
        private  int _secondNumber;

        /*public int FirstNumber
        {
            
            get;
            set;
        }

        public int SecondNumber
        {
            
            get;
            set;
        }*/

        public Calculate(int firstNumber, int secondNumber)
        {
            
            _firstNumber = firstNumber;
            _secondNumber = secondNumber;
        }
        
        public int Add()
        {
            return _firstNumber + _secondNumber;
        }

        public int Mul()
        {
            return _firstNumber * _secondNumber;
        }

    }
}