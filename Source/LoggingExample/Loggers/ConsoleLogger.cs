using System;

namespace LoggingExample
{
    public class ConsoleLogger : ILogger 
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}