using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CourseWork.Reports;
using Microsoft.Reporting.WinForms;
using SweetShop.Models.Entities;

namespace Reports
{
    public partial class StatisticsReport : Form
    {
        public StatisticsReportModel ReportModel { get; }

        public StatisticsReport()
        {
            InitializeComponent();
        }
        public StatisticsReport(
            StatisticsReportModel reportModel
            )
            :this()
        {
            ReportModel = reportModel;
        }
        private void StatisticsReport_Load(object sender, EventArgs e)
        {

            ReportParameter from = new ReportParameter("FromDate", ReportModel.Filter.FromDate.Value.Date.ToString("d"));
            ReportParameter to = new ReportParameter("ToDate", ReportModel.Filter.ToDate.Value.Date.ToString("d"));

            var productStatisticsDS = new ReportDataSource()
            {
                Value = ReportModel.ProductsStatistics ?? new List<ProductsStatistics>(),
                Name = "ProductStatisticsDataSet"
            };
            var categoryStatisticsDS = new ReportDataSource()
            {
                Value = ReportModel.CategoryStatistics ?? new List<CategoryStatistics>(),
                Name = "CategoryStatisticsDataSet"
            };
            reportViewer1.LocalReport.DataSources.Add(productStatisticsDS);
            reportViewer1.LocalReport.DataSources.Add(categoryStatisticsDS);
            reportViewer1.LocalReport.SetParameters(new[] { from, to});
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
