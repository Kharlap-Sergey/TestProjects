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

        public static Warehouse Convert(WAREHOUSE warehouse, LOCATION location)
        {
            if (warehouse == null) throw new ArgumentNullException(nameof(warehouse));
            return new Warehouse
            {
                Id = warehouse.ID,
                Name = warehouse.NAME,
                Location = Convert(location),
                LocationId = location.ID
            };
        }

        public static WAREHOUSE Convert(Warehouse warehouse)
        {
            if (warehouse == null) throw new ArgumentNullException(nameof(warehouse));
            return new WAREHOUSE
            {
                ID = warehouse.Id,
                NAME = warehouse.Name,
                LOCATION_ID = warehouse.LocationId
            };
        }

        public static Location Convert(LOCATION location)
        {
            if (location == null) throw new ArgumentNullException(nameof(location));

            return new Location
            {
                Id = location.ID,
                CountryCode = location.COUNTRY_CODE,
                Location1 = location.LOCATION_1,
                Location2 = location.LOCATION_2,
                Location3 = location.LOCATION_3,
                Location4 = location.LOCATION_4
            };
        }

        public static LOCATION Convert(Location location)
        {
            if (location == null) throw new ArgumentNullException(nameof(location));

            return new LOCATION
            {
                ID = location.Id,
                COUNTRY_CODE = location.CountryCode,
                LOCATION_1 = location.Location1,
                LOCATION_2 = location.Location2,
                LOCATION_3 = location.Location3,
                LOCATION_4 = location.Location4
            };
        }
    }
}