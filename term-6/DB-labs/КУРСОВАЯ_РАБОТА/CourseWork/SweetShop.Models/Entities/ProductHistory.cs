namespace SweetShop.Models.Entities
{
    public class ProductHistory
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int WarehouseId { get; set; }
        public History History { get; set; }
        public int HistoryId { get; set; }
        public int Count { get; set; }
    }
}
