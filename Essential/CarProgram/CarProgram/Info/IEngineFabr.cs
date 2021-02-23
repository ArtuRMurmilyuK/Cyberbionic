namespace CarProgram.Info
{
    class EngineFabr : InfoMan
    {

        private string selectedEngine { get; set; }
        private string stringSelect { get; set; }

        public void CreateEngine(gasEngine, elecEngine)
        {
            switch (stringSelect)
            {
                case "gasEngine":
                {
                    selectedEngine = gasEngine;
                    break;
                }
                case "elecEngine":
                {
                    selectedEngine = elecEngine;
                    break;
                }
            }
        }
        
    }
}