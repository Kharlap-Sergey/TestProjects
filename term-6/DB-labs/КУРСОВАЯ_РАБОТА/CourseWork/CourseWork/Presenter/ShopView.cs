using System;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Presenter
{
    public partial class ShopView : UserControl
    {
        public Warehouse Model { get; }
        protected readonly Action<Warehouse, Action<Warehouse>> _editHandle;
        public ShopView()
        {
            InitializeComponent();
        }

        public ShopView(Warehouse model, Action<Warehouse, Action<Warehouse>> editHandle)
            : this()
        {
            _editHandle = editHandle;
            Model = model;
        }

        protected virtual void UpdatePresenter(Warehouse model = null)
        {
            model = model ?? Model;
            name_TB.Text = model.Name;
            cureCode_TB.Text = model.Location.CountryCode;
            location1_TB.Text = model.Location.Location1;
            location2_TB.Text = model.Location.Location2;
            location3_TB.Text = model.Location.Location3;
            location4_TB.Text = model.Location.Location4;
        }

        private void ShopView_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            _editHandle.Invoke(Model, UpdatePresenter);
        }
    }
}
