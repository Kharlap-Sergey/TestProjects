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

namespace Reports
{
    public partial class JournalReport : Form
    {
        private readonly List<JournalReportModel> _report;
        private readonly string _from;
        private readonly string _to;
        private readonly decimal _totalPrice;

        public JournalReport()
        {
            InitializeComponent();
        }

        public JournalReport(
            List<JournalReportModel> report,
            string from, 
            string to,
            decimal totalPrice
            )
        :this()
        {
            _report = report;
            _from = @from;
            _to = to;
            _totalPrice = totalPrice;
        }

        private void JournalReport_Load(object sender, EventArgs e)
        {
            ReportParameter from = new ReportParameter("FromDate", _from);
            ReportParameter to = new ReportParameter("ToDate", _to);
            ReportParameter totalPrice = new ReportParameter("TotalPrice", _totalPrice.ToString());
            var categoryStatisticsDS = new ReportDataSource()
            {
                Value = _report ?? new List<JournalReportModel>(),
                Name = "StatisticsDataSet"
            };
            reportViewer1.LocalReport.DataSources.Add(categoryStatisticsDS);
            reportViewer1.LocalReport.SetParameters(new[] { from, to, totalPrice });
            this.reportViewer1.RefreshReport();
        }
    }
}
