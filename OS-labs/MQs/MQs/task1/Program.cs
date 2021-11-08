using System;
using System.Messaging;
using System.Threading;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create if not exist and connect to the MQ
            using (var messageQueue1 = new MessageQueue(@".\Private$\q1"))
            using (var messageQueue2 = new MessageQueue(@".\Private$\q22"))
            {
                //set the journaling for queues 
                messageQueue1.UseJournalQueue = true;
                messageQueue1.MaximumJournalSize = 1000;
                messageQueue2.UseJournalQueue = true;
                messageQueue2.MaximumJournalSize = 1000;

                //var message = new CustomMessage
                //{
                //    TimeStamp = "new message",
                //    Content = "some text here"
                //};
                //send message
                //messageQueue1.Send(message);
            }


            var firstThread = new Task(
                () =>
                {
                    using ( var messageQueue1 = new MessageQueue( @".\Private$\q1" ) )
                    {

                        while (true)
                        {
                            messageQueue1.Formatter = 
                                new XmlMessageFormatter(new Type[] { typeof( CustomMessage ) });
                            var messageBody = (CustomMessage)messageQueue1.Receive().Body;
                            Console.WriteLine($"message form queue {messageBody.Content}");
                        }
                    }
                }
            );
            firstThread.Start();


            using ( var messageQueue1 = new MessageQueue( @".\Private$\q1" ) )
            {
                while (true)
                {
                    var message = new CustomMessage
                    {
                        TimeStamp = DateTime.UtcNow,
                        Content = (new Random()).Next().ToString()
                    };
                    Console.WriteLine( $"message to queue {message.Content}" );
                    messageQueue1.Send(message);
                    Thread.Sleep(10000);
                }
            }
        }
    }
}