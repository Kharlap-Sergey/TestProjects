using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            productsTableAdapter1.Fill(dataSet11.PRODUCTS);
            dataGridView1.DataSource = dataSet11.PRODUCTS;
        }
    }
}
