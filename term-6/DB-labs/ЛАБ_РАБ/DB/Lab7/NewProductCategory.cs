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
    public partial class NewProductCategory : Form
    {
        public NewProductCategory()
        {
            InitializeComponent();
        }


        private void NewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db2DataSet.PRODUCT_CATEGORIES' table. You can move, or remove it, as needed.
            this.pRODUCT_CATEGORIESTableAdapter.Fill(this.db2DataSet.PRODUCT_CATEGORIES);
            // TODO: This line of code loads data into the 'db2DataSet.PRODUCTS' table. You can move, or remove it, as needed.

        }

        private void pRODUCT_CATEGORIESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pRODUCT_CATEGORIESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db2DataSet);

        }
    }
}
