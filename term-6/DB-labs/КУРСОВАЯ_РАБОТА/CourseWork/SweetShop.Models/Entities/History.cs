using System;
using System.Collections.Generic;

namespace SweetShop.Models.Entities
{
    public class History
    {
        public int Id { get; set; }
        public HistoryType HistoryType { get; set; }
        public int HistoryTypeId { get; set; }
        public DateTime Date { get; set; }
        public virtual List<ProductHistory> ProductHistories { get; set; }
    }
}
