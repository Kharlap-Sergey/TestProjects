using Microsoft.EntityFrameworkCore;
using RestFullApi.Models.Entities;

namespace RestFullApi.Domain
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }

        public ApiDbContext(
            DbContextOptions<ApiDbContext> options
        )
            : base( options )
        {
        }
    }
}
