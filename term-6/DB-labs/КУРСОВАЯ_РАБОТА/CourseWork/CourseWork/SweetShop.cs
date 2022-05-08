﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class SweetShop : Form
    {
        public SweetShop()
        {
            InitializeComponent();
        }

        private void administration_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var administrationForm = new AdministrationForm
            {
                StartPosition = FormStartPosition.Manual, 
                Location = this.Location, 
                Size = this.Size
            };
            administrationForm.Show();
            administrationForm.Closed += (o, args) =>
            {
                this.Show();
            };
        }
    }
}
