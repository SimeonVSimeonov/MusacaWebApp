using Microsoft.EntityFrameworkCore;
using Musaca.Models;

namespace Musaca.Data
{
    public class MusacaAppDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbSettings.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<OrderProduct>()
                .HasKey(x => new { x.OrderId, x.ProductId });
        }
    }
}
