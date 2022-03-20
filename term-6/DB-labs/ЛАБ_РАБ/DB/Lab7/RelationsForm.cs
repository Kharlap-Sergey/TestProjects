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
    public partial class RelationsForm : Form
    {
        public RelationsForm()
        {
            InitializeComponent();
        }

        private void RelationsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db2DataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.db2DataSet.PRODUCTS);
            // TODO: This line of code loads data into the 'db2DataSet.PRODUCT_CATEGORIES' table. You can move, or remove it, as needed.
            this.pRODUCT_CATEGORIESTableAdapter.Fill(this.db2DataSet.PRODUCT_CATEGORIES);
            // TODO: This line of code loads data into the 'db2DataSet.HISTORIES' table. You can move, or remove it, as needed.
            this.hISTORIESTableAdapter.Fill(this.db2DataSet.HISTORIES);
            // TODO: This line of code loads data into the 'db2DataSet.HISTORY_TYPES' table. You can move, or remove it, as needed.
            this.hISTORY_TYPESTableAdapter.Fill(this.db2DataSet.HISTORY_TYPES);

        }
    }
}
