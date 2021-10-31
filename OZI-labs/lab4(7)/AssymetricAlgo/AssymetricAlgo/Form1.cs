using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AssymetricAlgo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public byte[] encryptedData;
        public byte[] decryptedData;

        static string KeyContainerName = "MyKeyContainer";
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, RSAPersistKeyInCsp(KeyContainerName));
        UnicodeEncoding ByteConverter = new UnicodeEncoding();

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                //RSAPersistKeyInCsp(KeyContainerName);
                richTextBox.Clear();
                byte[] dataToEncrypt = ByteConverter.GetBytes(plainText.Text);
                encryptedData = RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
                encryptedText.Text = ByteConverter.GetString(encryptedData);
                var p = RSA.ExportParameters(true);
                richTextBox.Text += "Текущий размер ключа:" + RSA.KeySize + " Модуль:" + p.Modulus[0].ToString() + " Показатель степени:" + p.Exponent[0].ToString();
                richTextBox.Text += "\n Размер ключей от " + RSA.LegalKeySizes[0].MinSize.ToString() + " до " + RSA.LegalKeySizes[0].MaxSize.ToString();
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Encryption failed.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox.Lines.Length > 5)
            {
                richTextBox.Clear();
            }

            decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
            decryptedText.Text = ByteConverter.GetString(decryptedData);
            var p = RSA.ExportParameters(true);
            richTextBox.Text += "\n P: ";
            for (int i = 0; i < 50; i++)
            {
                richTextBox.Text += p.P[i];
            }
            richTextBox.Text += "\n Q: ";
            for (int i = 0; i < 50; i++)
            {
                richTextBox.Text += p.Q[i];
            }
            richTextBox.Text += "\n N: ";
            for (int i = 0; i < 50; i++)
            {
                richTextBox.Text += p.Modulus[i];
            }

            richTextBox.Text += "\n e: ";
            for (int i = 0; i < p.Exponent.Length; i++)
            {
                richTextBox.Text += p.Exponent[i];
            }

            richTextBox.Text += "\n d: ";
            for (int i = 0; i < 50; i++)
            {
                richTextBox.Text += p.D[i];
            }
            richTextBox.Text += "\nlength " + p.P.Length;

        }


        public static CspParameters RSAPersistKeyInCsp(string ContainerName)
        {
            try
            {
                CspParameters cspParams = new CspParameters();
                cspParams.Flags = CspProviderFlags.UseDefaultKeyContainer;
                cspParams.KeyContainerName = ContainerName;
                Console.WriteLine("The RSA key was persisted in the container, \"{0}\".",
                    ContainerName);

                return cspParams;
            }
            catch (CryptographicException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

        }

        static public byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, RSAPersistKeyInCsp(KeyContainerName)))
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    encryptedData = RSA.Encrypt(DataToEncrypt, DoOAEPPadding);
                }
                return encryptedData;
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public byte[] RSADecrypt(byte[] DataToDecrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(2048, RSAPersistKeyInCsp(KeyContainerName)))
                {
                    RSA.ImportParameters(RSAKeyInfo);
                    decryptedData = RSA.Decrypt(DataToDecrypt, DoOAEPPadding);
                }
                return decryptedData;
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}

