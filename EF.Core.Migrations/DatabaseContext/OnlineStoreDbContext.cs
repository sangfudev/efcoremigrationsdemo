using EF.Core.Migrations.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF.Core.Migrations.DatabaseContext
{
    public class OnlineStoreDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "data source=localhost;Initial Catalog=EFCoreMigrationsDemo.Database;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

    }
}
