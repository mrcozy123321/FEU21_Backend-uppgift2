using FEU21_Backend_2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FEU21_Backend_2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categoríes { get; set; }
    }
}
