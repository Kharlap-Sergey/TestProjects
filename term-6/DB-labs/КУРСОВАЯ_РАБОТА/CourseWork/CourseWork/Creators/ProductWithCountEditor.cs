using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Creators
{
    public partial class ProductWithCountEditor : Form
    {
        private readonly List<Product> _availableProducts;
        private readonly Action<ProductHistory> _saveHandler;
        private readonly Action<ProductHistory> _removeHandler;
        public ProductHistory Model { get; private set; }

        public ProductWithCountEditor(
            ProductHistory model,
            List<Product> availableProducts,
            Action<ProductHistory> saveHandler,
            Action<ProductHistory> removeHandler
            )
        {
            _availableProducts = availableProducts;
            _saveHandler = saveHandler;
            _removeHandler = removeHandler;
            Model = model;
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            _removeHandler.Invoke(Model);
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateSource();
            _saveHandler(Model);
            this.Close();
        }

        private void UpdateSource()
        {
            var selectedProduct = (Product) products_comboBox.SelectedItem;
            Model.Product = selectedProduct;
            Model.Count = int.Parse(count_TB.Text);
        }

        private void InitPresenter()
        {
            products_comboBox.ValueMember = "Id";
            products_comboBox.DisplayMember = "Name";
            products_comboBox.DataSource = _availableProducts;
            if (Model.Product?.Id == null || Model.Product.Id == 0)
                delete_btn.Visible = false;
        }
        private void UpdatePresenter(ProductHistory model = null)
        {
            Model = model ?? Model;

            products_comboBox.SelectedValue = Model?.Product?.Id ?? 0;
            count_TB.Text = Model?.Count.ToString() ?? "0";
        }

        private void ProductWithCountEditor_Load(object sender, EventArgs e)
        {
            InitPresenter();
            UpdatePresenter();
        }
    }
}
