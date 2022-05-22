using System;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Presenter
{
    public partial class JournalPresenter : UserControl
    {
        private readonly string _product;
        private readonly string _price;
        private readonly string _count;
        private readonly string _date;

        public JournalPresenter()
        {
            InitializeComponent();
        }

        public JournalPresenter(
            string product,
            string price,
            string count,
            string date
            )
            :this()
        {
            _product = product;
            _price = price;
            _count = count;
            _date = date;
        }

        private void JournalPresenter_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            this.date.Text = _date;
            price.Text = _price.ToString();
            count.Text = _count.ToString();
            product.Text = _product;
        }
    }
}
