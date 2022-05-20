using System.Collections.Generic;
using SweetShop.Models.Entities;
using SweetShop.Models.Filters;

namespace Reports
{
    public class StatisticsReportModel
    {
        public HistoryFilter Filter { get; set; }

        public List<ProductsStatistics> ProductsStatistics { get; set; }
        public List<CategoryStatistics> CategoryStatistics { get; set; }
    }
}
