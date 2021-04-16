using System;
using System.IO;

namespace LoggingExample
{
    public class FileLogger : ILogger
    {
        protected string Filename;
        protected const string TimeFormatStr = "dd-MM-yyyy (h:mm:ss tt)";

        public FileLogger(string filename="output.log")
        {
            this.Filename = filename;

            using var sw = File.CreateText(this.Filename);
            sw.WriteLine("Log File created at: {0}", DateTime.Now.ToString(TimeFormatStr));
        }
        
        public void Log(string msg)
        {
            using var sw = File.AppendText(this.Filename);
            sw.WriteLine("{0}: {1}", DateTime.Now.ToString(TimeFormatStr), msg);
        }
    }
}