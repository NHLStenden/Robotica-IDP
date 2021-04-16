using System;
using System.IO;

namespace LoggingExample
{
    public class AsyncFileLogger : FileLogger
    {
        public AsyncFileLogger(string filename="output.log") : base(filename) { }

        public new async void Log(string msg)
        {
            await File.AppendAllTextAsync(this.Filename, $"{DateTime.Now.ToString(TimeFormatStr)}: {msg} {Environment.NewLine}");
        }
    }
}