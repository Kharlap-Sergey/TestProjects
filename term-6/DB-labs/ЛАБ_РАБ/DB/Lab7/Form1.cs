using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openRelations_btn_Click(object sender, EventArgs e)
        {
            var sideForm = new RelationsForm();
            sideForm.Show();
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            var sideForm = new Products();
            sideForm.Show();
        }
    }
}
