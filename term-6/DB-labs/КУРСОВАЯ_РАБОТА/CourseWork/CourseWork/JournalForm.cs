using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Filters;
using CourseWork.Presenter;
using Reports;
using SweetShop.BusinessLogic;
using SweetShop.Models.Filters;

namespace CourseWork
{
    public partial class JournalForm : Form
    {
        private readonly WarehouseService _warehouseService = new WarehouseService();
        private readonly ProductsService _productsService = new ProductsService();
        private readonly HistoryService _historyService = new HistoryService();

        public HistoryFilter HistoryFilterModel { get; } = new HistoryFilter
        {
            FromDate = DateTime.Parse("2002-05-14 00:00:00.000"),
            ToDate = DateTime.UtcNow
        };

        public JournalForm()
        {
            InitializeComponent();
        }

        private void UpdatePresenter()
        {
            var histories = _historyService.GetHistories(HistoryFilterModel, true);
            flowLayoutPanel1.Controls.Clear();

            var columns = new JournalPresenter(
                "product",
                "price",
                "count",
                "date"
            );
            flowLayoutPanel1.Controls.Add(columns);
            histories.ForEach(
                h =>
                {
                    h.ProductHistories.ForEach(
                        ph =>
                        {
                            var presenter = new JournalPresenter(
                                ph.Product.Name,
                                ph.Price.ToString(),
                                ph.Count.ToString(),
                                h.Date.Date.ToString("D")
                            );
                            flowLayoutPanel1.Controls.Add(presenter);
                        }
                        );
                }
                );
        }

        private void ShowFilter()
        {
            var filterForm = new HistoryFiltersForm(
                HistoryFilterModel,
                _warehouseService.GetWarehouses(),
                _historyService.GetHistoryTypes()
            );
            this.Enabled = false;
            filterForm.Closed += (sender, args) =>
            {
                this.Enabled = true;
                UpdatePresenter();
            };

            filterForm.Show();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFilter();
        }

        private void JournalForm_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            var supplies = new SuppliesForm()
            {
                StartPosition = FormStartPosition.Manual,
                Location = this.Location,
                Size = this.Size
            };
            supplies.Show();
            supplies.Closed += (o, args) =>
            {
                UpdatePresenter();

                this.Enabled = true;
            };
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var histories = _historyService.GetHistories(HistoryFilterModel, true);

            decimal total = 0;
            var parametrs = new List<JournalReportModel>();
            histories.ForEach(
                h =>
                {
                    h.ProductHistories.ForEach(
                        ph =>
                        {
                            total += ph.Price * Math.Abs(ph.Count);
                            var param = new JournalReportModel { 
                                Date = h.Date.Date.ToString("D"),
                                Price = ph.Price,
                                ProductName = ph.Product.Name,
                                Count = ph.Count
                            };
                            parametrs.Add(param);
                        }
                    );
                }
            );
            var report = new JournalReport
            (
                parametrs,
                HistoryFilterModel.FromDate.Value.ToString("D"),
                HistoryFilterModel.ToDate.Value.ToString("D"),
                total
            );
            report.Show();
        }
    }
}
