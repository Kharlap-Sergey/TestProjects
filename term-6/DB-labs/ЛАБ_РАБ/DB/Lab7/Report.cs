using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Lab7
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Products main = this.Owner as Products;
            string strFIO;
            if (main != null)
            {
                //strFIO=main.txtText.Text;
                var rowView = main.pRODUCTSBindingSource.Current as DataRowView;
                var row = rowView.Row as Db2DataSet.PRODUCTSRow;
                strFIO = row.NAME;

                ReportParameter pFIO = new ReportParameter("ReportParameter1", strFIO);
                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pFIO });
                this.reportViewer1.RefreshReport();
            }

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
