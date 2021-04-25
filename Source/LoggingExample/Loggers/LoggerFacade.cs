namespace LoggingExample
{
    public class LoggerFacade : ILogger
    {
        private static ILogger logger = new ConsoleLogger();
        // private static ILogger logger = new FileLogger();
        // private static ILogger logger = new AsyncFileLogger();

        public void Log(string msg)
        {
            logger.Log(msg);
        }
    }
}