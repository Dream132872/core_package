using Microsoft.EntityFrameworkCore;
using OnlineCourse.Web.Entities.Products;

namespace OnlineCourse.Web.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductGallery> ProductGalleries { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductSelectedCategory> ProductSelectedCategories { get; set; }
    }
}
