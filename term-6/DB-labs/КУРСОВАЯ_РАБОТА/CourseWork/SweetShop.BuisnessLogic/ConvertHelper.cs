using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Domain;
using SweetShop.Models.Entities;

namespace SweetShop.BusinessLogic
{
    public static class ConvertHelper
    {
        public static ProductCategory Convert(PRODUCT_CATEGORIES productCategory)
        {
            if (productCategory == null) throw new ArgumentNullException(nameof(productCategory));

            return new ProductCategory
            {
                Id = productCategory.ID,
                Name = productCategory.NAME
            };
        }

        public static PRODUCT_CATEGORIES Convert(ProductCategory productCategory)
        {
            if (productCategory == null) throw new ArgumentNullException(nameof(productCategory));

            return new PRODUCT_CATEGORIES
            {
                ID = productCategory.Id,
                NAME = productCategory.Name
            };
        }

        public static Product Convert(PRODUCT product, PRODUCT_CATEGORIES productCategory = null)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            ProductCategory category = null;
            if (productCategory != null)
                category = Convert(productCategory);

            return new Product()
            {
                Id = product.ID,
                Name = product.NAME,
                Category = category,
                CategoryId = category?.Id ?? 0,
                Price = product.PRICE
            };
        }
    }
}