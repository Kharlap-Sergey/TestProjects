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
using SweetShop.Models.Entities;

namespace CourseWork.Presenter
{
    public partial class HistoryFullPresenterForm : Form
    {
        private readonly History _history;

        public HistoryFullPresenterForm()
        {
            InitializeComponent();
        }

        public HistoryFullPresenterForm(
            History history
        )
            : this()
        {
            _history = history;
        }

        private void HistoryFullPresenterForm_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            date_TextBox.Text = _history.Date.Date.ToString();
            type_TextBox.Text = _history.HistoryType.Name;
            products_Panel.Controls.Clear();
            _history.ProductHistories.ForEach(
                ph =>
                {
                    products_Panel.Controls.Add(
                        new ProductWithCountView(
                            ph,
                            null
                        )
                    );
                    shop_TextBox.Text = ph.Warehouse.Name;
                }
            );
        }

        private void shop_TextBox_DoubleClick(object sender, EventArgs e)
        {
            var form = new ControlPresenter(new ShopView(
                _history.ProductHistories.First().Warehouse,
                null
            ));
            form.Closed += (o, args) => this.Enabled = true;

            this.Enabled = false;
            form.Show();
        }
    }
}