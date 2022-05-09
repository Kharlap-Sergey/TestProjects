namespace SweetShop.Models.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
    }
}
