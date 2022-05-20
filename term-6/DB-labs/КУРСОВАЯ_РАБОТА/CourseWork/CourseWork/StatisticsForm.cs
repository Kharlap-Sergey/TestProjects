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
using SweetShop.Models.Entities;
using SweetShop.Models.Filters;

namespace CourseWork
{
    public partial class StatisticsForm : Form
    {
        private readonly WarehouseService _warehouseService = new WarehouseService();
        private readonly ProductsService _productsService = new ProductsService();
        private readonly HistoryService _historyService = new HistoryService();

        public HistoryFilter HistoryFilterModel { get; } = new HistoryFilter
        {
            FromDate = DateTime.Parse("2002-05-14 00:00:00.000"),
            ToDate = DateTime.UtcNow
        };

        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFilter();
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

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            UpdatePresenter();
        }

        private void UpdatePresenter()
        {
            this.histories_panel.Controls.Clear();
            var histories = _historyService.GetHistories(HistoryFilterModel);
            histories.ForEach(
                h =>
                {
                    this.histories_panel.Controls.Add(
                        new HistoryPresenter(
                            h.Date,
                            h.HistoryType,
                            () =>
                            {
                                
                                var history = _historyService.GetHistory(h.Id);
                                //ShowFullHistory(history);
                                var reportForm = new HistoryReportV2(
                                    history
                                );
                                reportForm.Show();
                            }
                        )
                    );
                }
                );
        }

        private void ShowFullHistory(History history)
        {
            var filterForm = new HistoryFullPresenterForm(
                history
            );
            this.Enabled = false;
            filterForm.Closed += (sender, args) =>
            {
                this.Enabled = true;
            };

            filterForm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //ShowFullHistory(history);
            var reportForm = new StatisticsReport(
                new StatisticsReportModel
                {
                    Filter = HistoryFilterModel,
                    ProductsStatistics = _historyService.GetProductsStatistics(HistoryFilterModel.FromDate.Value, HistoryFilterModel.ToDate.Value),
                    CategoryStatistics = _historyService.GetCategoryStatistics(HistoryFilterModel.FromDate.Value, HistoryFilterModel.ToDate.Value)
                }
            );
            reportForm.Show();
        }
    }
}
