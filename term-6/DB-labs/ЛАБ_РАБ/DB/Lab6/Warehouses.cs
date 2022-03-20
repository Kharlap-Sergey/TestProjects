using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Warehouses : Form
    {
        public Warehouses()
        {
            InitializeComponent();
        }

        private void Warehouses_Load(object sender, EventArgs e)
        {
            warehousesTableAdapter1.Fill(dataSet11.WAREHOUSES);
            dataGridView1.DataSource = dataSet11.WAREHOUSES;
        }
    }
}
