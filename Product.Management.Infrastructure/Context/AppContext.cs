using Microsoft.EntityFrameworkCore;
using Product.Management.Domain.Entity;

namespace Product.Management.Infrastructure.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options) { }           
        
        public DbSet<FinancialProduct> FinancialProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
