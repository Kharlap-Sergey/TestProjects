using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestFinolazer
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new TestClass();
            t.Name = "Sergey";
            var t2 = new Test2Class();
            t2.Name = "Mikita";
            Thread.Sleep(100);
            GC.Collect();
            GC.Collect();
            GC.Collect();
            t2.Name = "";
            GC.Collect();
            GC.Collect();
            GC.SuppressFinalize(t2);
            GC.WaitForPendingFinalizers();
            Console.WriteLine("dmsahfajkshdfkashbdkjmhasldkhj");
            for ( int index = 0; index < 1000000000000000; index++ )
            {
                var tt = new TestClass();
                GC.Collect();
            }
        }
    }
}