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

namespace CourseWork.Presenter
{
    public partial class ProductCategoryView : UserControl
    {
        private readonly Action<ProductCategory, Action<ProductCategory>> _editHandle;
        public ProductCategory Category { get; }

        public ProductCategoryView()
        {
            InitializeComponent();
        }

        public ProductCategoryView(
            ProductCategory category,
            Action<ProductCategory, Action<ProductCategory>> editHandle
            )
            :this()
        {
            _editHandle = editHandle;
            Category = category;
            this.textBox1.Text = Category.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _editHandle.Invoke(Category, cat => UpdatePresenter());
        }

        private void UpdatePresenter()
        {
            this.textBox1.Text = Category.Name;
        }
    }
}
