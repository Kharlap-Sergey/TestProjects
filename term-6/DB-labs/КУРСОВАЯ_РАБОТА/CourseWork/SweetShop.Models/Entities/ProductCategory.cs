using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SweetShop.Models.Entities
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = null;
    }
}
