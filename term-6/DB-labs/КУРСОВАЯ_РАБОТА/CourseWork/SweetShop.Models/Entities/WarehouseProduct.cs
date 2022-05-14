namespace SweetShop.Models.Entities
{
    public class WarehouseProduct
    {
        public int Count { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Warehouse Warehouse { get; set; }
        public int WarehouseId { get; set; }
    }
}
