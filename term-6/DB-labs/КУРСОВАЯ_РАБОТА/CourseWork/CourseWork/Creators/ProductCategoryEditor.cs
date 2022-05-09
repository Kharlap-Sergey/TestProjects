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
    public partial class ProductCategoryEditor : Form
    {
        private readonly Action<ProductCategory> _saveHandler;
        private readonly Action<ProductCategory> _deleteHandler;
        public ProductCategory Category { get; }

        public ProductCategoryEditor()
        {
            InitializeComponent();
        }

        public ProductCategoryEditor(
            ProductCategory  category,
            Action<ProductCategory> saveHandler,
            Action<ProductCategory> deleteHandler
            )
            :this()
        {
            _saveHandler = saveHandler;
            _deleteHandler = deleteHandler;
            Category = category;
        }

        private void ProductCategoryEditor_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(!FormHelper.ShowYesOrNow("The product category will be permanently deleted", "Warning"))
                return;

            this._deleteHandler.Invoke(Category);
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateSource();
            this._saveHandler(Category);
            this.Close();
        }

        private void UpdateSource()
        {
            this.Category.Name = this.name_textBox.Text;
            UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            if (Category.Id == 0)
                this.delte_btn.Visible = false;

            this.name_textBox.Text = this.Category.Name;
        }
    }
}
