using System;
using System.IO;

namespace LoggingExample
{
    public class FileLogger : ILogger
    {
        protected readonly string Filename;
        public FileLogger(string filename="output.log")
        {
            this.Filename = filename;

            using var sw = File.CreateText(this.Filename);
            sw.WriteLine($"Log File created at: {ILogger.Timestamp()}");
        }
        
        public void Log(string msg)
        {
            using var sw = File.AppendText(this.Filename);
            sw.WriteLine($"{ILogger.Timestamp()}: {msg}");
        }
    }
}