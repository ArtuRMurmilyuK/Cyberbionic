 using System;

namespace ExampleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger;

            String loggerType = "text";

            switch (loggerType)
            {
                case "database":
                    logger = new DatabaseLogger();
                    break;
                default:
                    logger = new TextLogger();
                    break;
            }

            LogManager logManager = new LogManager(logger);

            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception e)
            {
                logManager.Log(e.Message);
            }
        }
    }

    interface ILogger
    {
        void Log(String message);
    }

    class LogManager
    {
        private ILogger _logger;

        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(String message)
        {
            _logger.Log(message);
        }
    }
    class TextLogger : ILogger
    {
        public void Log(String message)
        {
            Console.WriteLine("Log to A text file: " + message);
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log(String message)
        {
            Console.WriteLine("Log to a database: " + message);
        }
    }
}
