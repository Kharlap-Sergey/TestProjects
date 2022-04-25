using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        private static string _connectionMiString { get; set; } =
            @"Data Source=SIARHEI-KHARLAP\SQLEXPRESS;Initial Catalog=DB2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static string ConnectionString { get => _connectionMiString; }
        public ContextDataContext Context { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Context = new ContextDataContext(ConnectionString);
        }

        private void manipulate_Click(object sender, EventArgs e)
        {
            var form = new Tables
            {
                Context = Context
            };

            form.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Products
            {
                Context = Context
            };

            form.Show(this);
        }
    }
}
