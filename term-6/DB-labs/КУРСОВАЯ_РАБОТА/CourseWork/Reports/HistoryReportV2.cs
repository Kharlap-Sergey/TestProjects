using System;
using System.Linq;
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

        private void HistoryReportV2_Load(object sender, EventArgs e)
        {

            ReportParameter historyDate = new ReportParameter("Date", History.Date.Date.ToString("d"));
            ReportParameter type = new ReportParameter("Type", History.HistoryType.Name);
            Warehouse warehouse = new Warehouse();
            decimal totalPrice = 0;
            var dataSource = new ReportDataSource()
            {
                Value = History.ProductHistories.Select(p =>
                {
                    warehouse = p.Warehouse;
                    totalPrice += Math.Abs(p.Count) * p.Product.Price;

                    return new HistoryReportProductModel
                    {
                        Count = Math.Abs(p.Count),
                        Price = p.Product.Price,
                        CategoryName = p.Product.Category?.Name,
                        ProductName = p.Product.Name
                    };
                }).ToList(),
                Name = "ProductHistoriesDataSet"
            };
            ReportParameter to = new ReportParameter("To", warehouse.Name);
            ReportParameter address = new ReportParameter("Address", GetAddress(warehouse));
            ReportParameter price = new ReportParameter("TotalPrice", totalPrice.ToString());

            reportViewer1.LocalReport.SetParameters(new[] { historyDate, to, type, address, price });
            reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private string GetAddress(Warehouse w)
        {
            return $"{w.Location.CountryCode}, {w.Location.Location1} {w.Location.Location2}, {w.Location.Location3} {w.Location.Location4}";
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
