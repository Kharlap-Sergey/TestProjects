using System;
using System.Messaging;
using System.Threading;

namespace task2
{
    class Program
    {
        static void Main( string[] args )
        {
            var thread = new Thread(new ThreadStart(Thread1));
            thread.Start();

            Thread2();
        }

        static void Thread1()
        {
            var startMessage = "hello";
            using ( var outQ = new MessageQueue( @".\Private$\q1" ) )
            using ( var inQ = new MessageQueue( @".\Private$\q22" ) )
            {
                inQ.Formatter =
                    new XmlMessageFormatter( new Type[] { typeof( string ) } );
                var message = startMessage;
                while (true)
                {
                    outQ.Send( message );
                    message = (string)inQ.Receive().Body;
                    Console.WriteLine(message);
                    message += "1";
                }
            }
        }

        static void Thread2()
        {
            using ( var inQ = new MessageQueue( @".\Private$\q1" ) )
            using ( var outQ = new MessageQueue( @".\Private$\q22" ) )
            {
                inQ.Formatter =
                    new XmlMessageFormatter( new Type[] { typeof( string ) } );
                var message = "";
                while ( true )
                {
                    message = ( string )inQ.Receive().Body;
                    Console.WriteLine( message );
                    message += "2";
                    outQ.Send( message );
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
