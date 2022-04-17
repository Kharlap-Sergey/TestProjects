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
    public partial class Tables : Form
    {
        public ContextDataContext Context { get; set; }

        public Tables()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tables_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Context.GetTable<PRODUCT>();
        }

        private void applyFilter_btn_Click(object sender, EventArgs e)
        {
            var products = Context.GetTable<PRODUCT>();
            dataGridView2.DataSource =
                from p in products
                where p.NAME.Contains(this.productNameFilter_textBox.Text)
                select p;
        }
    }
}
