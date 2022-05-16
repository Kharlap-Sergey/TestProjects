using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Reports;
using Microsoft.Reporting.WinForms;
using SweetShop.Models.Entities;

namespace Reports
{
    public partial class HistoryReportV2 : Form
    {
        public History History { get; private set; }

        public HistoryReportV2()
        {
            InitializeComponent();
        }

        public HistoryReportV2(
            History history
        )
            : this()
        {
            History = history;
        }
        private void HistoryReport_Load(object sender, EventArgs e)
        {
            ReportParameter historyDate = new ReportParameter("HistoryDate", History.Date.Date.ToString());
            var dataSource = new ReportDataSource()
            {
                Value = History.ProductHistories.Select(p => new HistoryReportProductModel
                {
                    Count = p.Count,
                    Price = p.Product.Price,
                    CategoryName = p.Product.Category?.Name,
                    ProductName = p.Product.Name
                }),
                Name = "ProductHistoriesDataSet"
            };
            reportViewer1.LocalReport.SetParameters(new[] { historyDate });
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void HistoryReportV2_Load(object sender, EventArgs e)
        {

            ReportParameter historyDate = new ReportParameter("HistoryDate", History.Date.Date.ToString());
            var dataSource = new ReportDataSource()
            {
                Value = History.ProductHistories.Select(p => new HistoryReportProductModel
                {
                    Count = p.Count,
                    Price = p.Product.Price,
                    CategoryName = p.Product.Category?.Name,
                    ProductName = p.Product.Name
                }),
                Name = "ProductHistoriesDataSet"
            };
            //reportViewer1.LocalReport.SetParameters(new[] { historyDate });
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
