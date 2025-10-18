using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 1, Name = "IPhone 13", Price = 50000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 2, Name = "IPhone 14", Price = 60000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 3, Name = "IPhone 15", Price = 70000, IsActive = false });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 4, Name = "IPhone 16", Price = 80000, IsActive = true });
            modelBuilder.Entity<Product>().HasData(new Product() { ProductId = 5, Name = "IPhone 17", Price = 90000, IsActive = true });

        }
        public DbSet<Product> Products { get; set; }
    }
}