using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetShop.Models.Entities
{
    public class ProductsStatistics
    {
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int TotalCount { get; set; }
    }
}
