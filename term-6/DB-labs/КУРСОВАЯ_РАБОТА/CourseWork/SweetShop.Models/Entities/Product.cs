﻿namespace SweetShop.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
    }
}
