using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Creators;
using CourseWork.Presenter;
using SweetShop.BusinessLogic;
using SweetShop.Models.Entities;

namespace CourseWork
{
    public partial class AdministrationForm : Form
    {
        ProductsService _productsService = new ProductsService();
        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void cancel_menuBtn_Click(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void save_menuBtn_Click(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void add_menuBtn_Click(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {
           UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            var service = new ProductsService();
            var products = service.GetProducts();
            var productCategories = service.GetProductCategories();
            this.productCategories_panal.Controls.Clear();
            productCategories.ForEach(
                cat => this.productCategories_panal.Controls.Add(
                    new ProductCategoryView(cat, EditHandle)
                    )
                );
        }

        private void New()
        {
            if (pages_tabControl.TabIndex == productCategories_tabPage.TabIndex)
            {
                NewProductCategory();
                return;
            }
        }

        private void NewProductCategory()
        {
            EditHandle(new ProductCategory(), (pc) => UpdatePresenter());
        }

        private void EditHandle(ProductCategory productCategory, Action<ProductCategory> postAction)
        {
            var productCategoryEditor = new ProductCategoryEditor(
                productCategory,
                (pc) =>
                {
                    ExecuteUnderCatch(_);
                    
                    void _()
                    {
                        _productsService.AddOrUpdateCategory(pc);
                        postAction.Invoke(pc);
                    }
                },
                pc =>
                {
                    var categoryWithProducts = _productsService.GetProductCategory(pc.Id, true);

                    if (categoryWithProducts.Products != null && categoryWithProducts.Products.Any())
                    {
                        if(FormHelper.ShowYesOrNow("Warning", "Are you sure?\nIt will cause cascade products deleting!"))
                        {
                            _productsService.DeleteProductCategoryWithCascade(pc);
                        }
                        return;
                    }

                    _productsService.DeleteProductCategory(pc);
                }
            );
            productCategoryEditor.Show();
        }

        private void ExecuteUnderCatch(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
