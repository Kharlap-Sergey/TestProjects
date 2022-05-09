using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Creators
{
    public partial class ProductEditor : Form
    {
        private readonly Action<Product> _saveHandler;
        private readonly Action<Product> _deleteHandler;
        public Product Product { get; }
        public List<ProductCategory> Categories { get; }

        public ProductEditor()
        {
            InitializeComponent();
        }

        public ProductEditor(
            Product product,
            List<ProductCategory> categories,
            Action<Product> saveHandler,
            Action<Product> deleteHandler
        )
            : this()
        {
            _saveHandler = saveHandler;
            _deleteHandler = deleteHandler;
            Product = product;
            Categories = categories;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateSource();
            _saveHandler(Product);
            this.Close();
        }

        private void UpdateSource(Product product = null)
        {
            product = product ?? Product;
            product.Name = this.name_textBox.Text;
            product.Price = decimal.Parse(this.price_textBox.Text);
            var cat = (ProductCategory) productCategory_ComboBox.SelectedItem;
            product.CategoryId = cat.Id;
            product.Category = cat;
            UpdatePresenter(product);
        }
        private void UpdatePresenter(Product product = null)
        {
            product = product ?? Product;
            if (product.Id == 0)
                this.delete_btn.Visible = false;

            this.name_textBox.Text = product.Name;
            this.price_textBox.Text = product.Price.ToString();
            productCategory_ComboBox.DisplayMember = "Name";
            productCategory_ComboBox.ValueMember = "Id";
            this.productCategory_ComboBox.DataSource = Categories;

            if (product?.CategoryId != null)
                this.productCategory_ComboBox.SelectedValue = product?.CategoryId;
            //this.name_textBox.Text = this.Category.Name;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (!FormHelper.ShowYesOrNow("All changes you applied will be cancelled", "Warning"))
                return;
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!FormHelper.ShowYesOrNow("The product category will be permanently deleted", "Warning"))
                return;
            _deleteHandler?.Invoke(Product);
            this.Close();
        }

        private void price_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductEditor_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void price_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
