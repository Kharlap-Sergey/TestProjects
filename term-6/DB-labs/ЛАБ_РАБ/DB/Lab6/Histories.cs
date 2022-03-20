using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Histories : Form
    {
        public Histories()
        {
            InitializeComponent();
        }

        private void Histories_Load(object sender, EventArgs e)
        {
            historiesTableAdapter1.Fill(dataSet11.HISTORIES);
            dataGridView1.DataSource = dataSet11.HISTORIES;
        }
    }
}
