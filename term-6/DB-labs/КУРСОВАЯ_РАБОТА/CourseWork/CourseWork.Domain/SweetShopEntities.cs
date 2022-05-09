using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.SqlClient;
using CourseWork.Domain.Models;

namespace CourseWork.Domain
{
    public class SweetShopEntities : DbContext
    {
        public SweetShopEntities()
            : base("Data Source=SIARHEI-KHARLAP\\SQLEXPRESS;Initial Catalog=SweetShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PRODUCT_CATEGORIES>().HasKey(pc => pc.ID);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PRODUCT_CATEGORIES> PRODUCT_CATEGORIES { get; set; }
        public DbSet<PRODUCT> PRODUCTS { get; set; }

        public virtual void SOFT_PRODUCT_CATEGORY_DELETE(int? cATEGORY_ID)
        {
            var cATEGORY_IDParameter = cATEGORY_ID.HasValue ?
                new SqlParameter("CATEGORY_ID", cATEGORY_ID) :
                new SqlParameter("CATEGORY_ID", typeof(int));

            Database.ExecuteSqlCommand("exec SOFT_PRODUCT_CATEGORY_DELETE @CATEGORY_ID", cATEGORY_IDParameter);
        }
    }
}
