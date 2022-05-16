using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using CourseWork.Domain;
using CourseWork.Domain.StoredProceduresTypes;
using SweetShop.Models.Entities;
using SweetShop.Models.Filters;

namespace SweetShop.BusinessLogic
{
    public class HistoryService
    {
        private readonly SweetShopEntities _context;
        private readonly ProductsService _productsService = new ProductsService();
        public HistoryService()
        {
            _context = new SweetShopEntities();
        }
        public List<HistoryType> GetHistoryTypes()
        {
            var types = _context.HistoryTypes.Select(ConvertHelper.Convert).ToList();
            return types;
        }

        public void CreateNewHistory(
            Warehouse warehouse,
            HistoryType historyType,
            DateTime date,
            List<(Product product, int amount)> selectedProducts
        )
        {
            var selected = selectedProducts.Select(pc => new ProductListType
                {Amount = pc.amount, ProductId = pc.product.Id}).ToList();

            BaseHistoryEvent proc;
            if (historyType.Name.EndsWith("SALES", StringComparison.CurrentCultureIgnoreCase))
                proc = new NewSalesProcedure
                {
                    Date = date,
                    SelectedProducts = selected,
                    WarehouseId = warehouse.Id
                };
            else
                proc = new NewSupplyProcedure()
                {
                    Date = date,
                    SelectedProducts = selected,
                    WarehouseId = warehouse.Id
                };

            _context.NEW_HISTORY_EVENT(proc);
        }

        public List<History> GetHistories(HistoryFilter filter)
        {
            var query = _context.Histories.Select(h => h).Include(h => h.HistoryType);
            if (filter.FromDate.HasValue)
                query = query.Where(h => h.DATE >= filter.FromDate.Value);
            if (filter.ToDate.HasValue)
                query = query.Where(h => h.DATE <= filter.ToDate.Value);
            if (filter.SelectedTypes.Any())
                query = query.Where(h => filter.SelectedTypes.Contains(h.HISTORY_TYPE_ID));
            if (filter.SelectedStores.Any())
                query = query
                    .Join(
                        _context.HistoryProducts,
                        h => h.ID,
                        hp => hp.HISTORY_ID,
                        (h, hp) => new
                        {
                            h,
                            hp
                        }
                    )
                    .Where(joint => filter.SelectedStores.Contains(joint.hp.WAREHOUSE_ID))
                    .Select(joint => joint.h)
                    .GroupBy(h => h)
                    .Select(h => h.Key);

            query = filter.IsDescending ? query.OrderByDescending(h => h.DATE) : query.OrderBy(h => h.DATE);

            var histories = query.ToList();
            return histories.Select(
                history =>
                    new History
                    {
                        Id = history.ID,
                        Date = history.DATE,
                        HistoryType = ConvertHelper.Convert(history.HistoryType),
                        HistoryTypeId = history.HISTORY_TYPE_ID,
                    }
            ).ToList();


            //var histories = query.Join(
            //        _context.HistoryProducts,
            //        h => h.ID,
            //        hp => hp.HISTORY_ID,
            //        (h, hp) => new
            //        {
            //            h,
            //            hp
            //        })
            //    .ToList();

            //var result = histories.GroupBy(joint => joint.h)
            //    .Select(
            //        g =>
            //        {
            //            var history = g.Key;
                        
            //            return new History
            //            {
            //                Id = history.ID,
            //                Date = history.DATE,
            //                HistoryType = ConvertHelper.Convert(history.HistoryType),
            //                HistoryTypeId = history.HISTORY_TYPE_ID,
            //                ProductHistories = g.Select(
            //                    joint => new ProductHistory
            //                    {
            //                        Count = joint.hp.COUNT,
            //                        HistoryId = history.ID,
            //                        ProductId = joint.hp.PRODUCT_ID,
            //                        WarehouseId = joint.hp.WAREHOUSE_ID
            //                    }
            //                ).ToList()
            //            };
            //        }
            //    )
            //    .ToList();
            //return result;
        }

        public History GetHistory(int id)
        {
            var temp = _context.HistoryProducts.ToList();
            var history = _context.Histories
                .Include(h => h.HistoryType)
                .FirstOrDefault(h => h.ID == id);

            if (history == null)
                return null;

            var historyProducts = _context.HistoryProducts.Include(hp => hp.Product).Include(hp => hp.Warehouse)
                .Where(hp => hp.HISTORY_ID == history.ID)
                .ToList();

            return new History
            {
                HistoryType = ConvertHelper.Convert(history.HistoryType),
                Date = history.DATE,
                HistoryTypeId = history.HISTORY_TYPE_ID,
                Id = history.ID,
                ProductHistories = historyProducts.Select(
                    hp =>
                    {
                        var category = _productsService.GetProductCategory(hp.Product.PRODUCT_CATEGORY_ID);
                        var product = ConvertHelper.Convert(hp.Product);
                        product.Category = category;
                        product.CategoryId = category.Id;

                        return new ProductHistory
                        {
                            Count = hp.COUNT,
                            Product = product,
                            Warehouse = ConvertHelper.Convert(hp.Warehouse, hp.Warehouse.Location),
                            ProductId = product.Id,
                            WarehouseId = hp.WAREHOUSE_ID
                        };
                    }
                    ).ToList()
            };
        }
    }
}
