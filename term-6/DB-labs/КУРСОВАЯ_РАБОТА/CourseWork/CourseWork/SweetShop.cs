using System;
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
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
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

        private void supplies_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var supplies = new SuppliesForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location,
                Size = this.Size
            };
            supplies.Show();
            supplies.Closed += (o, args) =>
            {
                this.Show();
            };
        }

        private void statistic_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var statisticsForm = new StatisticsForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location,
                Size = this.Size
            };
            statisticsForm.Show();
            statisticsForm.Closed += (o, args) =>
            {
                this.Show();
            };
        }
    }
}
