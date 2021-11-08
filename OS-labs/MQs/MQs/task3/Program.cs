using System;
using System.Messaging;
using System.Threading;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var server1 = new Thread(new ThreadStart(Server1));
            server1.Start();

            var server2 = new Thread(new ThreadStart(Server2));
            server2.Start();

            Client();
        }

        static void Server1()
        {
            var startMessage = "hello";
            using (var outQ = new MessageQueue(@".\Private$\q1"))
            {
                while (true)
                {
                    var message = DateTime.Now;
                    outQ.Send(message, "local");

                    Thread.Sleep(2000);
                }
            }
        }

        static void Server2()
        {
            using (var outQ = new MessageQueue(@".\Private$\q1"))
            {
                while (true)
                {
                    var message = DateTime.UtcNow;
                    outQ.Send(message, "utc");

                    Thread.Sleep(2000);
                }
            }
        }

        static void Client()
        {
            using (var inQ = new MessageQueue(@".\Private$\q1"))
            {
                inQ.Formatter =
                    new XmlMessageFormatter(new Type[] {typeof( DateTime ) });
                inQ.MessageReadPropertyFilter = new MessagePropertyFilter
                {
                    AppSpecific = true,
                    Body = true,
                    AttachSenderId = true,
                    Label = true
                };
                while (true)
                {
                    var message = inQ.Receive();
                    var body = (DateTime) message.Body;
                    var lable = message.Label;
                    Console.WriteLine(lable);
                    Console.WriteLine(body);
                }
            }
        }
    }
}