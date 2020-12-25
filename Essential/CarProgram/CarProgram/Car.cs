namespace CarProgram
{
    class Car
    {
        private readonly IEngine _engine;
        private readonly ITransmission _transmission;

        public Car(IEngine engine, ITransmission transmission)
        {
            engine = _engine;
            transmission = _transmission;
        }

        public void ChosenEngine()
        {
            _engine.ChoiceEngine();
        }

        public void ChosenTransmission()
        {
            _transmission.ChoiceTransmission();
        }
    }
}
