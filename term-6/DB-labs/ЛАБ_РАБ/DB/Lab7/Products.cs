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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void pRODUCTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            UpdateCurrent();
            this.pRODUCTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db2DataSet);

        }

        private void UpdateCurrent()
        {
            var rowView = pRODUCTSBindingSource.Current as DataRowView;
            var row = rowView.Row as Db2DataSet.PRODUCTSRow;
            row.IS_DELETED = false;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db2DataSet.PRODUCT_CATEGORIES' table. You can move, or remove it, as needed.
            this.pRODUCT_CATEGORIESTableAdapter.Fill(this.db2DataSet.PRODUCT_CATEGORIES);
            pRODUCTSBindingSource.CurrentChanged += (o, args) =>
            {
                try
                {
                    var rowView = pRODUCTSBindingSource.Current as DataRowView;
                    var row = rowView.Row as Db2DataSet.PRODUCTSRow;
                    var table = row.Table as Db2DataSet.PRODUCTSDataTable;
                    var rel = table.ParentRelations["FK_PRODUCT_PRODUCT_CATEGORY"];

                    var rowP = row.GetParentRow(rel) as Db2DataSet.PRODUCT_CATEGORIESRow;
                    // name_textBox.Text = row?.NAME ?? "";
                }
                catch
                {
                   // name_textBox.Text = "";
                }
            };

            // TODO: This line of code loads data into the 'db2DataSet.PRODUCTS' table. You can move, or remove it, as needed.
            this.pRODUCTSTableAdapter.Fill(this.db2DataSet.PRODUCTS);


        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void pRODUCT_CATEGORY_IDTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void productCat_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = productCat_combo.SelectedValue;
            if (val == null)
                return;
            pRODUCT_CATEGORY_IDTextBox.Text = $"{(int) val}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new NewProductCategory();
            form.Show();
            form.Closed += (o, args) =>
            {
                this.pRODUCT_CATEGORIESTableAdapter.Fill(this.db2DataSet.PRODUCT_CATEGORIES);
                //pRODUCTCATEGORIESBindingSource1.DataSource = this.db2DataSet.PRODUCT_CATEGORIES;
            };
        }
    }
}
