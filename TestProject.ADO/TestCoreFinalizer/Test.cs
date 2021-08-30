using System;
using System.Diagnostics;
using System.Threading;

namespace TestFinolazer
{
    public class TestClass
    {
        public string Name { get; set; }
        ~TestClass()
        {
            Debug.WriteLine( "finalize" );
            Thread.Sleep( 1000000 );
            Debug.WriteLine( "finalized" );
        }
    }
    public class Test2Class
    {
        public string Name { get; set; }
        ~Test2Class()
        {
            Debug.WriteLine( "finalize2" );
            //Thread.Sleep( 100000 );
            Debug.WriteLine( "finalized2" );
        }
    }
}