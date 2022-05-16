using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace SweetShop.Models.Filters
{
    public class HistoryFilter
    {
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public List<int> SelectedTypes { get; set; } = new List<int>();
        public List<int> SelectedStores { get; set; } = new List<int>();
        public bool IsDescending { get; set; } = true;
    }
}
