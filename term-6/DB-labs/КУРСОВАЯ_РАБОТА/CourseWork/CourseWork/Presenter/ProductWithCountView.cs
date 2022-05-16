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
    public partial class ProductWithCountView : UserControl
    {
        public ProductHistory Model { get; private set; }
        private readonly Action<ProductHistory, Action<ProductHistory>> _editHandler;

        public ProductWithCountView()
        {
            InitializeComponent();
        }

        public ProductWithCountView(
            ProductHistory model,
            Action<ProductHistory, Action<ProductHistory>> editHandler
            )
            :this()
        {
            Model = model;
            _editHandler = editHandler;
        }

        private void ProductWithCountView_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void UpdatePresenter(ProductHistory model = null)
        {
            edit_btn.Enabled = edit_btn.Visible = _editHandler != null;
            Model = model ?? Model;

            name_textBox.Text = Model?.Product?.Name ?? "";
            price_textBox.Text = Model?.Product?.Price.ToString() ?? "";
            categoryName_textBox.Text = Model?.Product?.Category?.Name ?? "0";
            count_textBox.Text = Model?.Count.ToString() ?? "0";
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            _editHandler.Invoke(Model, UpdatePresenter);
        }
    }
}
