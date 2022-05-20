using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using CourseWork.Domain.Models;
using CourseWork.Domain.Models.Functions;
using CourseWork.Domain.StoredProceduresTypes;
using EntityFrameworkExtras.EF5;

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
            modelBuilder.Entity<HISTORY_PRODUCT>().HasKey(hp => new {hp.HISTORY_ID, hp.PRODUCT_ID});
            //modelBuilder.Entity<HISTORY>()
            //    .HasMany<PRODUCT>(h => h.Products)
            //    .WithMany()
            //    .Map(
            //        cs =>
            //        {
            //            cs.ToTable("HISTORY_PRODUCT");
            //        }
            //        );

            modelBuilder.Entity<HISTORY>()
                .HasMany(h => h.HistoryProducts)
                .WithRequired(hp => hp.History);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PRODUCT_CATEGORIES> ProductCategories { get; set; }
        public DbSet<PRODUCT> Products { get; set; }
        public DbSet<WAREHOUSE> Warehouses { get; set; }
        public DbSet<LOCATION> Locations { get; set; }
        public DbSet<HISTORY_TYPE> HistoryTypes { get; set; }
        public DbSet<HISTORY> Histories { get; set; }
        public DbSet<HISTORY_PRODUCT> HistoryProducts { get; set; }

        public virtual void SOFT_PRODUCT_CATEGORY_DELETE(int? cATEGORY_ID)
        {
            var cATEGORY_IDParameter = cATEGORY_ID.HasValue ?
                new SqlParameter("CATEGORY_ID", cATEGORY_ID) :
                new SqlParameter("CATEGORY_ID", typeof(int));

            Database.ExecuteSqlCommand("exec SOFT_PRODUCT_CATEGORY_DELETE @CATEGORY_ID", cATEGORY_IDParameter);
        }

        public virtual void NEW_HISTORY_EVENT(BaseHistoryEvent procedureValues)
        {
            Database.ExecuteStoredProcedure(procedureValues);
        }

        public virtual List<GET_STATISTICS_PRODUCTS_Model> GET_STATISTICS_PRODUCTS(DateTime from, DateTime to)
        {
            var fromParameter =
                new SqlParameter("@FROM_DATE", from);
            var toParameter = new SqlParameter("@TO_DATE",to);
            var temp = Database
                .SqlQuery<GET_STATISTICS_PRODUCTS_Model>("SELECT Product as ProductName, Category as CategoryName, Total_Count as TotalCount FROM GET_STATISTICS_PRODUCTS(@FROM_DATE,@TO_DATE)", fromParameter,
                    toParameter)
                .ToList();

            return temp;
        }
        
        public virtual List<GET_STATISTICS_CATEGORY_PRICE_Model> GET_STATISTICS_CATEGORY_PRICE(DateTime from, DateTime to)
        {
            var fromParameter =
                new SqlParameter("@FROM_DATE", from);
            var toParameter = new SqlParameter("@TO_DATE",to);
            var temp = Database
                .SqlQuery<GET_STATISTICS_CATEGORY_PRICE_Model>("SELECT *  FROM GET_STATISTICS_CATEGORY_PRICE(@FROM_DATE,@TO_DATE)", fromParameter,
                    toParameter)
                .ToList();

            return temp;
        }

    }
}
