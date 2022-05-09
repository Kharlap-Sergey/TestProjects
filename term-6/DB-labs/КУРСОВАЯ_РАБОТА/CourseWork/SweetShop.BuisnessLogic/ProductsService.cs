using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text.RegularExpressions;
using CourseWork.Domain;
using SweetShop.Models.Entities;

namespace SweetShop.BusinessLogic
{
    public class ProductsService
    {
        private readonly SweetShopEntities _context;

        public ProductsService()
        {
            _context = new SweetShopEntities();
        }

        #region product

        public List<Product> GetProducts()
        {
            var context = new SweetShopEntities();

            var temp = context.PRODUCTS.Join(
                context.PRODUCT_CATEGORIES,
                p => p.PRODUCT_CATEGORY_ID,
                pc => pc.ID,
                (p, pc) =>
                    new
                    {
                        Product = p,
                        Category = pc
                    }
            ).ToList();
            return temp
                .Select(
                    join => ConvertHelper.Convert(join.Product, join.Category)
                )
                .ToList();
        }

        public void AddOrUpdateProduct(Product product)
        {
            _context.PRODUCTS.AddOrUpdate(ConvertHelper.Convert(product));
            _context.SaveChanges();
        }

        public Product DeleteProduct(int productId)
        {
            var toRemove = _context.PRODUCTS.First(pcd => pcd.ID == productId);
            var removed = _context.PRODUCTS.Remove(toRemove);
            _context.SaveChanges();
            return ConvertHelper.Convert(removed);
        }

        #endregion


        #region product category

        public List<ProductCategory> GetProductCategories(bool includeProducts = false)
        {
            var context = new SweetShopEntities();

            if (!includeProducts)
                return context.PRODUCT_CATEGORIES.ToList().Select(pc => ConvertHelper.Convert(pc)).ToList();
            //return context.PRODUCTS.Join(
            //        context.PRODUCT_CATEGORIES,
            //        p => p.PRODUCT_CATEGORY_ID,
            //        pc => pc.ID,
            //        (p, pc) =>
            //            new
            //            {
            //                Product = p,
            //                Category = pc
            //            }
            //    )
            //    .ToList()
            //    .GroupBy(
            //        joint => joint.Category,
            //        (key, group) => new 
            //        {
            //            key,
            //            Items = group.ToList()
            //        }
            //    )
            //    .ToList()
            //    .Select(
            //        group =>
            //        {
            //            var category = ConvertHelper.Convert(group.Key);
            //            category.Products = group.ToList().Select(g => ConvertHelper.Convert(g.Product, group.Key))
            //                .ToList();
            //        }
            //    )
            //    .ToList();
            return null;
        }

        public ProductCategory GetProductCategory(int id, bool includeProducts = false)
        {
            var context = new SweetShopEntities();

            var category = context.PRODUCT_CATEGORIES.FirstOrDefault(pc => pc.ID == id);
            if (category == null)
                return null;

            var categoryModel = ConvertHelper.Convert(category);
            if (includeProducts)
                categoryModel.Products = context.PRODUCTS
                    .Where(p => p.PRODUCT_CATEGORY_ID == categoryModel.Id)
                    .ToList()
                    .Select(p => ConvertHelper.Convert(p, category))
                    .ToList();

            return categoryModel;
        }

        public void AddOrUpdateCategory(ProductCategory pc)
        {
            var context = new SweetShopEntities();

            context.PRODUCT_CATEGORIES.AddOrUpdate(ConvertHelper.Convert(pc));
            context.SaveChanges();
        }

        public ProductCategory DeleteProductCategory(ProductCategory pc)
        {
            var toRemove = _context.PRODUCT_CATEGORIES.First(pcd => pcd.ID == pc.Id);
            var removed = _context.PRODUCT_CATEGORIES.Remove(toRemove);
            _context.SaveChanges();
            return ConvertHelper.Convert(removed);
        }

        public void DeleteProductCategoryWithCascade(ProductCategory pc)
        {
            if (pc == null)
                throw new ArgumentNullException(nameof(pc));

            _context.SOFT_PRODUCT_CATEGORY_DELETE(pc.Id);
        }

        #endregion

    }
}