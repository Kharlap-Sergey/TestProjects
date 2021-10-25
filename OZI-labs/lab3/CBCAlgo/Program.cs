using System;

namespace CBCAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            var cbc = new CBC(logger);
            cbc.GenerateIv();

            string plainText = "Siarhei";
            int key = 412;

            var encrypted = cbc.Encrypt(plainText, key);

            logger.Log("encrypted text:");
            logger.Log(encrypted);

            logger.Log("-----------------------------------------------");
            logger.Log( "-----------------------------------------------" );
            logger.Log( "-----------------------------------------------" );
            logger.Log( "-----------------------------------------------" );

            var decrypted = cbc.Decrypt(encrypted, key);

            logger.Log("decrypted text:");
            logger.Log(decrypted);
        }
    }
}