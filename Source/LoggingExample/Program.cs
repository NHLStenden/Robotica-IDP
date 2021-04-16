using System;

namespace LoggingExample
{
    class Program
    {
        private static void Main(string[] args)
        {
            var logger = new AsyncFileLogger();
            logger.Log("test");
            logger.Log("bla");
            logger.Log("test");
            
            Console.WriteLine("bla");
        }
    }
}
