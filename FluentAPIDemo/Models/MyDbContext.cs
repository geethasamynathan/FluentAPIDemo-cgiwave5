using Microsoft.EntityFrameworkCore;
namespace FluentAPIDemo.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .HasAlternateKey("CategoryName")
                        .HasName("uq_CategoryName"); ;

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasAlternateKey(e => e.ProductName)
                      .HasName("uq_ProductName");
                entity.Property(e => e.ProductId)
                      .HasColumnType("char(4)");
                entity.HasOne(c => c.Category)
                      .WithMany(p => p.Products)
                      .HasForeignKey(c => c.CategoryId)
                      .HasConstraintName("fk_CategoryId");
            });
        }


    }
}

