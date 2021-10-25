using System;
using System.Collections;
using System.Globalization;
using System.Security.Cryptography;
using System.Windows.Forms.Layout;

namespace WindowsFormsApp1
{
    public class S_Des
    {
        private readonly ILogger _logger;

        public S_Des(ILogger logger)
        {
            _logger = logger;
        }

        static int[] P10 = new int[]
        {
            3, 5, 2, 7, 4, 10, 1, 9, 8, 6
        };

        static int[] IP = new int[]
        {
            2, 6, 3, 1, 4, 8, 5, 7
        };

        static int[] IPR = new int[]
        {
            4, 1, 3, 5, 7, 2, 8, 6
        };

        private static int[] P10_with1S = new int[]
        {
            5, 2, 7, 4, 3, 1, 9, 8, 6, 10
        };

        private static int[] P10_with2S = new int[]
        {
            7, 4, 3, 5, 2, 8, 6, 10, 1, 9
        };

        static int[] P8 = new int[]
        {
            6, 3, 7, 4, 8, 5, 10, 9
        };

        static int[] Epr = new int[]
        {
            4, 1, 2, 3, 2, 3, 4, 1
        };

        static int[] P4 = new int[]
        {
            2, 4, 3, 1
        };

        public string K1 { get; set; }
        public string K2 { get; set; }

        public void InitKeys(int key)
        {
            var bitkey = Convert.ToString(key, 2);
            while (bitkey.Length < 10)
            {
                bitkey = "0" + bitkey;
            }

            this._logger.Log($"init value {bitkey}");

            //Apply P10;

            var temp = ApplyP(bitkey, P10);
            this._logger.Log($"P10 value {temp}");

            var sp10 = ApplyP(bitkey, P10_with1S);
            this._logger.Log($"SP10 value {temp}");

            var k1 = ApplyP(sp10, P8);
            this._logger.Log($"k1 value {k1}");

            var sp10_2 = ApplyP(bitkey, P10_with2S);
            this._logger.Log($"SP10_2 value {sp10_2}");

            var k2 = ApplyP(sp10_2, P8);
            this._logger.Log($"k1 value {k2}");

            this.K1 = k1;
            this.K2 = k2;
        }

        public char Encrypt(string c)
        {
            return Encrypt((char) Convert.ToInt32(c, 2));
        }

        public char Encrypt(char c)
        {
            return SDes(c, this.K1, this.K2);
        }

        public char Decrypt(string c)
        {
            return Decrypt((char) Convert.ToInt32(c, 2));
        }

        public char Decrypt(char c)
        {
            return SDes(c, this.K2, this.K1);
        }

        public char SDes(char c, string k1 = null, string k2 = null)
        {
            k1 = k1 ?? this.K1;
            k2 = k2 ?? this.K2;

            _logger.Log($"symbol - {c}");

            int ascii = (int) c;
            _logger.Log($"symbol in ASCII - {ascii}");

            var bytes = Convert.ToString(ascii, 2);
            while (bytes.Length < 8)
            {
                bytes = "0" + bytes;
            }

            _logger.Log($"symbol in bytes - {bytes}");

            //ip
            var ip = ApplyP(bytes, IP);
            _logger.Log($"IP {ip}");

            var l = GetL(ip);
            var r = GetR(ip);
            _logger.Log($"left - {l}  right - {r}");

            var afterF = F(l, r, k1);
            _logger.Log($"after f - {afterF}");

            var afterSw = SW(afterF);
            _logger.Log($"after SW - {afterSw}");

            l = GetL(afterSw);
            r = GetR(afterSw);
            _logger.Log($"left - {l}  right - {r}");

            afterF = F(l, r, k2);
            _logger.Log($"after f - {afterF}");

            var ipR = ApplyP(afterF, IPR);
            _logger.Log($"res2 - {ipR}");

            var res10 = Convert.ToInt32(ipR, 2);
            _logger.Log($"res10 - {res10}");

            var charRes = (char) res10;
            _logger.Log($"res - {charRes}");
            return charRes;
        }

        public string F(string L, string R, string k)
        {
            var epr = ApplyP(R, Epr);
            _logger.Log($"epr {epr}");

            var res = Xor(epr, k);
            _logger.Log($"after xor {res}");

            var l = GetL(res);
            var r = GetR(res);

            _logger.Log($"l - {l}, r - {r}");

            var slsr = SL(l) + SR(r);
            _logger.Log($"Sl_Sr - {slsr}");
            var p4 = ApplyP(slsr, P4);
            _logger.Log($"p4 {p4}");

            return Xor(L, p4) + R;
        }


        public string SL(string l)
        {
            var temp = SAny(l);
            var rowI = temp.Item1;
            var columnI = temp.Item2;

            var S = new int[,]
            {
                {1, 0, 3, 2},
                {3, 2, 1, 0},
                {0, 2, 1, 3},
                {3, 1, 3, 1}
            };

            return ToBiteString(S[rowI, columnI], 2);
        }

        public string SR(string r)
        {
            var temp = SAny(r);
            var rowI = temp.Item1;
            var columnI = temp.Item2;

            var S = new int[,]
            {
                {1, 1, 2, 3},
                {2, 0, 1, 3},
                {3, 0, 1, 0},
                {2, 1, 0, 3}
            };

            return ToBiteString(S[rowI, columnI], 2);
        }

        public Tuple<int, int> SAny(string s)
        {
            var s1 = "" + s[0] + s[3];
            var s2 = "" + s[1] + s[2];


            var rowI = Convert.ToInt32(s1, 2);
            var columnI = Convert.ToInt32(s2, 2);

            return new Tuple<int, int>(rowI, columnI);
        }

        public static string GetL(string s)
        {
            return s.Substring(0, s.Length / 2);
        }

        public static string GetR(string s)
        {
            return s.Substring(s.Length / 2);
        }

        public static string Xor(string a, string b)
        {
            var res = "";
            for (int i = 0; i < a.Length; i++)
            {
                var xor = (int.Parse(a[i].ToString()) ^ int.Parse(b[i].ToString())).ToString();
                res += xor;
            }

            return res;
        }

        public string ApplyP(string key, int[] p)
        {
            var s = "";
            foreach (int id in p)
            {
                s += key[id - 1];
            }

            return s;
        }

        public static string ToBiteString(int value, int length)
        {
            var bites = Convert.ToString(value, 2);

            while (bites.Length < length)
            {
                bites = '0' + bites;
            }

            return bites;
        }

        public static string SW(string s)
        {
            var l = GetL(s);
            var r = GetR(s);

            return r + l;
        }
    }
}