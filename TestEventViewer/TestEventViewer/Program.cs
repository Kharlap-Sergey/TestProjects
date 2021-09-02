using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEventViewer
{
    class Program
    {
        static void Main( string[] args )
        {
            try
            {
                EventLog.WriteEntry( "WebOps - Shopify Service", "Test", EventLogEntryType.Information );
                Console.WriteLine("Tested successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}
