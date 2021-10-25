using System;
using WindowsFormsApp1;
using Microsoft.VisualBasic;

namespace CBCAlgo
{
    public class CBC
    {
        private readonly ILogger _logger;
        public string Iv { get; set; } = "00000000";

        public CBC(ILogger logger)
        {
            this._logger = logger;
        }

        public string Encrypt(string text, int key)
        {
            var answer = "";
            this._logger.Log("encrypting started.....");

            var des = new S_Des(this._logger);

            des.InitKeys(key);

            var previous = this.Iv;

            foreach (var character in text)
            {
                var bitwise = S_Des.ToBiteString((int) character, 8);
                var afterXor = S_Des.Xor(previous, bitwise);

                var encrypted = des.Encrypt(afterXor);
                answer += encrypted;
                previous = S_Des.ToBiteString((int) encrypted, 8);
            }

            this._logger.Log( "encrypting finished....." );

            return answer;
        }

        public string Decrypt(string text, int key)
        {
            var answer = "";
            this._logger.Log("decrypting started.....");

            var des = new S_Des(this._logger);

            des.InitKeys(key);

            var previous = this.Iv;

            foreach (var character in text)
            {
                var bitwise = S_Des.ToBiteString((int) character, 8);

                var decrypted = S_Des.ToBiteString(des.Decrypt(bitwise), 8);

                var afterXor = S_Des.Xor(previous, decrypted);
                answer += (char)Convert.ToInt32( afterXor, 2 );

                previous = bitwise;
            }
            this._logger.Log( "decrypting finished....." );
            return answer;
        }

        public void GenerateIv()
        {
            this.Iv = "01011100";
        }
    }
}