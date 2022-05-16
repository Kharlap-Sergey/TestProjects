using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.SqlClient;
using CourseWork.Domain.Models;
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
    }
}
