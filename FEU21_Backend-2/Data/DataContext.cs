using FEU21_Backend_2.Models;
using Microsoft.EntityFrameworkCore;

namespace FEU21_Backend_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().ToContainer("Products").HasPartitionKey(x => x.PartitionKey);
        }
    }
}
