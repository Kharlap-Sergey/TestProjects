using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var logger = new Logger();
            var des = new S_Des(logger);
            var key = 138;

            des.InitKeys(key);
            logger.Log("encrypting ......");
            //var encrypted = des.Encrypt('b');
            logger.Log("decrypting ......");
            var encrypted = (char) 188;
            var decrypted = des.Decrypt(encrypted);
        }
    }
}