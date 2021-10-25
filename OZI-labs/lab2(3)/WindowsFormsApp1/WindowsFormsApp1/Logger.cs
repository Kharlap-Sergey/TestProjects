using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debugger.Log(1, "a", message+'\n');    
        }
    }
}
