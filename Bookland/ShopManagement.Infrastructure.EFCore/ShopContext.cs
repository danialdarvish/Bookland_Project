using Microsoft.EntityFrameworkCore;
using ShopManagement.Domain.AuthorAgg;
using ShopManagement.Domain.BannerAgg;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.BookCategoryAgg;
using ShopManagement.Domain.CategoryAgg;
using ShopManagement.Domain.QuoteAgg;
using ShopManagement.Domain.SlideAgg;
using ShopManagement.Infrastructure.EFCore.Mapping;

namespace ShopManagement.Infrastructure.EFCore
{
    public class ShopContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Banner> Banners { get; set; }

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(CategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
