using System;
using WindowsFormsApp1;

namespace CBCAlgo
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
