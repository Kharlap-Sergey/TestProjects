using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SweetShop.Models.Entities;

namespace CourseWork.Creators
{
    public partial class ShopEditor : Form
    {
        private readonly Action<Warehouse> _saveHandler;
        private readonly Action<Warehouse> _deleteHandler;
        public Warehouse Model { get; }

        public ShopEditor()
        {
            InitializeComponent();
        }

        public ShopEditor(
            Warehouse model,
            Action<Warehouse> saveHandler,
            Action<Warehouse> deleteHandler
        )
            : this()
        {
            Model = model;
            _saveHandler = saveHandler;
            _deleteHandler = deleteHandler;
        }


        private void ShopEditor_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void UpdateSource()
        {
            Model.Name = name_TB.Text;
            Model.Location.CountryCode = cureCode_TB.Text;
            Model.Location.Location1 = location1_TB.Text;
            Model.Location.Location2 = location2_TB.Text;
            Model.Location.Location3 = location3_TB.Text;
            Model.Location.Location4 = location4_TB.Text;
            UpdatePresenter();
        }

        private void UpdatePresenter(Warehouse model = null)
        {
            model = model ?? Model;
            this.delete_btn.Visible = model.Id > 0;

            model.Location = model.Location ?? new Location(); 
            name_TB.Text = model.Name;
            cureCode_TB.Text = model.Location.CountryCode;
            location1_TB.Text = model.Location.Location1;
            location2_TB.Text = model.Location.Location2;
            location3_TB.Text = model.Location.Location3;
            location4_TB.Text = model.Location.Location4;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            UpdateSource();
            _saveHandler(Model);
            this.Close();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (!FormHelper.ShowYesOrNow("All changes you applied will be cancelled", "Warning"))
                return;
            this.Close();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!FormHelper.ShowYesOrNow("The shop will be permanently deleted", "Warning"))
                return;
            _deleteHandler?.Invoke(Model);
            this.Close();
        }
    }
}
