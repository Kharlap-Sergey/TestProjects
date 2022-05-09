using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Domain;
using CourseWork.Domain.Models;
using SweetShop.Models.Entities;

namespace SweetShop.BusinessLogic
{
    public static class ConvertHelper
    {
        public static ProductCategory Convert(PRODUCT_CATEGORIES productCategories)
        {
            if (productCategories == null) throw new ArgumentNullException(nameof(productCategories));

            return new ProductCategory
            {
                Id = productCategories.ID,
                Name = productCategories.NAME
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

        public static Product Convert(PRODUCT product, PRODUCT_CATEGORIES productCategories = null)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            ProductCategory category = null;
            if (productCategories != null)
                category = Convert(productCategories);

            return new Product()
            {
                Id = product.ID,
                Name = product.NAME,
                Category = category,
                CategoryId = category?.Id ?? 0,
                Price = product.PRICE
            };
        }

        public static PRODUCT Convert(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            return new PRODUCT
            {
                ID = product.Id,
                NAME = product.Name,
                PRODUCT_CATEGORY_ID = product.CategoryId,
                PRICE = product.Price
            };
        }
    }
}