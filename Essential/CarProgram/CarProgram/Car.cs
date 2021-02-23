namespace CarProgram
{
    class Car
    {
        private  IEngine _engine;
        private  ITransmission _transmission;

        public Car(IEngine engine, ITransmission transmission)
        {
            _engine = engine;
            _transmission = transmission;
        }

        public void ChosenEngine()
        {
            _engine.ChoiceEngine();
        }

        public void ChosenTransmission()
        {
            _transmission.ChoiceTransmission();
        }

        public IEngine Engine
        {
            get { return _engine; }
        }

        public ITransmission Transmission
        {
            get { return _transmission; }
        }
    }
}
