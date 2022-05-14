using System;
using SweetShop.Models.Entities;

namespace CourseWork.Presenter
{
    public partial class ProductView : BasePresenter<Product>
    {
        public ProductView()
            :base()
        {
            Model = new Product();
            Model.Category = new ProductCategory();

            InitializeComponent();
            edit_btn.Visible = false;
        }

        public ProductView(
            Product model,
            Action<Product, Action<Product>> editHandle
        )
            : base(model, editHandle)
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            _editHandle.Invoke(Model, UpdatePresenter);
        }

        protected void UpdatePresenter(Product model = null)
        {
            model = model ?? Model;

            this.name_textBox.Text = model.Name;
            this.categoryName_textBox.Text = model.Category.Name;
            this.price_textBox.Text = model.Price.ToString();
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            UpdatePresenter(Model);
        }
    }
}
