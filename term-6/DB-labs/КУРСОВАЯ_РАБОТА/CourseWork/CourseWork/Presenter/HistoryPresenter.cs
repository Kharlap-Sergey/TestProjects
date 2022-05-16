using System;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Presenter
{
    public partial class HistoryPresenter : UserControl
    {
        private readonly DateTime _date;
        private readonly HistoryType _type;
        private readonly Action _moreClick;

        public HistoryPresenter()
        {
            InitializeComponent();
        }

        public HistoryPresenter(
            DateTime date,
            HistoryType type,
            Action moreClick
        )
            :this()
        {
            _date = date;
            _type = type;
            _moreClick = moreClick;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void HistoryPresenter_Load(object sender, EventArgs e)
        {
            date_Text.Text = _date.ToString();
            categoryName_Text.Text = _type.Name;
        }

        private void more_btn_Click(object sender, EventArgs e)
        {
            _moreClick.Invoke();
        }
    }
}
