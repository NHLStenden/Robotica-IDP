using System;

namespace LoggingExample
{
    public interface ILogger
    {
        private static string TimeFormatStr => "dd-MM-yyyy (h:mm:ss tt)";
        
        void Log(string msg);

        static string Timestamp()
        {
            return DateTime.Now.ToString(TimeFormatStr);
        }
    }
}