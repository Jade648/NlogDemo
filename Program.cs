using System;

namespace NlogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           var config = new NLog.Config.LoggingConfiguration();

// Targets where to log to: File and Console
var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "file.txt" };
var logconsole = new NLog.Targets.ConsoleTarget("logconsole");
            
// Rules for mapping loggers to targets            
config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);
            
// Apply config           
NLog.LogManager.Configuration = config;
        }
    }
}

