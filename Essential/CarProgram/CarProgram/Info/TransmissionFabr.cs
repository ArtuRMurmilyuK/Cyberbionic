namespace CarProgram.Info
{
    public class TransmissionFabr : InfoMan
    {
        void CreateTransmission()
        {
            switch (stringSelect)
            {
                case "autoTransmission":
                {
                    selectedTransmission = autoTransmission;
                    break;
                }
                case "manualTransmission":
                {
                    selectedTransmission = manualTransmission;
                    break;
                }
            }
        }
    }
}
