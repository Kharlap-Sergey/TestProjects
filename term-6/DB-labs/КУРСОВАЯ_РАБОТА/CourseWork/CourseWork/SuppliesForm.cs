using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CourseWork.Creators;
using CourseWork.Presenter;
using SweetShop.BusinessLogic;
using SweetShop.Models.Entities;

namespace CourseWork
{
    public partial class SuppliesForm : Form
    {
        private readonly WarehouseService _warehouseService = new WarehouseService();
        private readonly ProductsService _productsService = new ProductsService();
        private readonly HistoryService _historyService = new HistoryService();

        private List<Product> products = new List<Product>();
        private List<Product> choosenProducts = new List<Product>();
        public SuppliesForm()
        {
            InitializeComponent();
        }

        private void SuppliesForm_Load(object sender, EventArgs e)
        {
            InitData();
            UpdatePresenter(); 
        }

        private void InitData()
        {
            var warehouses = _warehouseService.GetWarehouses();
            shop_comboBox.DisplayMember = "Name";
            shop_comboBox.ValueMember = "Id";
            shop_comboBox.DataSource = warehouses;

            var historyTypes = _historyService.GetHistoryTypes();
            type_comboBox.DisplayMember = "Name";
            type_comboBox.ValueMember = "Id";
            type_comboBox.DataSource = historyTypes;

            supplies_dateTimePicker.Text = DateTime.UtcNow.ToString();
            products = _productsService.GetProducts();
        }

        protected void UpdatePresenter()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new Product();
            product.Category = new ProductCategory();
            var model = new ProductHistory
            {
                Count = 0,
                Product = product
            };

            ProductWithCountView editor = new ProductWithCountView();

            var productEditorAfterCreate = new ProductWithCountEditor(
                model,
                products,
                (ph) =>
                {
                    editor = new ProductWithCountView(model, _editor);
                    this.products_panel.Controls.Add(editor);
                    this.choosenProducts.Add(model.Product);
                },
                ph =>
                {
                    this.products_panel.Controls.Remove(editor);
                    this.choosenProducts.Remove(model.Product);
                }
            );

            productEditorAfterCreate.Show();

            void _editor(ProductHistory _model, Action<ProductHistory> postAction)
            {
                var productEditor = new ProductWithCountEditor(
                    _model,
                    products,
                    postAction,
                    ph =>
                    {
                        this.products_panel.Controls.Remove(editor);
                        this.choosenProducts.Remove(model.Product);
                    }
                );
                productEditor.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (choosenProducts.Any())
            {
                var selectedStore = (Warehouse) shop_comboBox.SelectedItem;
                var selectedType = (HistoryType) type_comboBox.SelectedItem;
                var date = DateTime.Parse(supplies_dateTimePicker.Text);
                var selectedProducts = new List<(Product, int)>();
                foreach (Control control in this.products_panel.Controls)
                {
                    var pwcv = (ProductWithCountView) control;
                    var history = pwcv.Model;

                    selectedProducts.Add((history.Product, history.Count));
                }
                _historyService.CreateNewHistory(selectedStore, selectedType, date, selectedProducts);
                this.Close();
            }
            else
            {
                FormHelper.ShowYesOrNow(
                    "warning",
                    "At least one product is required"
                );
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
           
                this.Enabled = true;
                var administrationForm = new AdministrationForm
                {
                    StartPosition = FormStartPosition.Manual,
                    Location = this.Location,
                    Size = this.Size
                };
                administrationForm.Show();
                administrationForm.Closed += (o, args) =>
                {
                    this.Enabled = true;
                    products = _productsService.GetProducts();
                    //shop = _warehouseService.GetWarehouses();
                };
        }
    }
}
