using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Products : Form
    {
        public ContextDataContext Context { get; set; }

        public Products()
        {
            InitializeComponent();
        }

        private PRODUCT _product;
        private int current = 0;
        private void Products_Load(object sender, EventArgs e)
        {
            //bindingNavigator1.BindingSource = new BindingSource(Context.PRODUCTs, "");
            _product = TakeCurrent(0);
            RefreshCurrentInformation(_product);
        }

        private PRODUCT TakeCurrent(int pos)
        {
            try
            {
                var product = Context.PRODUCTs.ToList()[pos];
                current = pos;
                return product;
            }
            catch
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _product = TakeCurrent(current + 1);
            RefreshCurrentInformation(_product);
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            _product = TakeCurrent(current-1);
            RefreshCurrentInformation(_product);
        }

        private void RefreshCurrentInformation(PRODUCT product)
        {
            if (product == null)
                return;
            this.textBox1.Text = product.NAME;
            this.textBox2.Text = product.PRICE.ToString();
            this.textBox3.Text = product.PRODUCT_CATEGORy?.NAME;
            this.textBox4.Text = product.PRODUCT_CATEGORY_ID.ToString();
        }

        private void Edit()
        {
            try
            {
                _product.NAME = this.textBox1.Text;
                _product.PRICE = decimal.Parse(this.textBox2.Text);
                _product.PRODUCT_CATEGORY_ID = int.Parse(this.textBox4.Text);
                this.Context.SubmitChanges();
            }
            catch
            {
                RefreshCurrentInformation(TakeCurrent(current));
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            RefreshCurrentInformation(TakeCurrent(current));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Context.PRODUCTs.DeleteOnSubmit(_product);
                this.Context.SubmitChanges();
                RefreshCurrentInformation(TakeCurrent(0));
            }
            catch
            {

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            _product = new PRODUCT();
            this.Context.PRODUCTs.InsertOnSubmit(_product);
            RefreshCurrentInformation(_product);
        }
    }
}
