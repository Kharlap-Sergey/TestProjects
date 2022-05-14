using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using CourseWork.Domain;
using SweetShop.Models.Entities;

namespace SweetShop.BusinessLogic
{
    public class HistoryService
    {
        private readonly SweetShopEntities _context;
        public HistoryService()
        {
            _context = new SweetShopEntities();
        }
        public List<HistoryType> GetHistoryTypes()
        {
            var types = _context.HistoryTypes.Select(ConvertHelper.Convert).ToList();
            return types;
        }

    }
}
