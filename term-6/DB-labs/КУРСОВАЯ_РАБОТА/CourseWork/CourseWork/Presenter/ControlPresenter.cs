using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.Presenter
{
    public partial class ControlPresenter : Form
    {
        private readonly Control _control;

        public ControlPresenter()
        {
            InitializeComponent();
        }

        public ControlPresenter(
            Control control
        ): this()
        {
            _control = control;
        }
        private void ControlPresenter_Load(object sender, EventArgs e)
        {
            this.Controls.Add(_control);
        }
    }
}
