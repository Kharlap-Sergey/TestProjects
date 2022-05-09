using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using CourseWork.Domain;
using SweetShop.Models.Entities;

namespace SweetShop.BusinessLogic
{
    public class WarehouseService
    {
        private readonly SweetShopEntities _context;
        public WarehouseService()
        {
            _context = new SweetShopEntities();
        }
        public List<Warehouse> GetWarehouses()
        {
            var warehouses = _context.Warehouses.Include(w => w.Location).ToList();
            return warehouses.Select(w => ConvertHelper.Convert(w, w.Location)).ToList();
        }

        public void AddOrUpdate(Warehouse warehouse)
        {
            _context.Locations.AddOrUpdate(ConvertHelper.Convert(warehouse.Location));
            _context.Warehouses.AddOrUpdate(ConvertHelper.Convert(warehouse));
            _context.SaveChanges();
        }

        public void Delete(int warehouseId)
        {
            var toRemove = _context.Warehouses.First(pcd => pcd.ID == warehouseId);
            var removed = _context.Warehouses.Remove(toRemove);
            _context.SaveChanges();
        }
    }
}
