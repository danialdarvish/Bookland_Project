using _01_BooklandQuery.Contract.Author;
using _01_BooklandQuery.Contract.Banner;
using _01_BooklandQuery.Contract.Book;
using _01_BooklandQuery.Contract.BookCategory;
using _01_BooklandQuery.Contract.BookCategoryCount;
using _01_BooklandQuery.Contract.Quote;
using _01_BooklandQuery.Contract.Slide;
using _01_BooklandQuery.Query;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Application.Contracts.Banner;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Application.Contracts.Category;
using ShopManagement.Application.Contracts.Quote;
using ShopManagement.Application.Contracts.Slide;
using ShopManagement.Domain.AuthorAgg;
using ShopManagement.Domain.BannerAgg;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.BookCategoryAgg;
using ShopManagement.Domain.CategoryAgg;
using ShopManagement.Domain.QuoteAgg;
using ShopManagement.Domain.SlideAgg;
using ShopManagement.Infrastructure.EFCore;
using ShopManagement.Infrastructure.EFCore.Repository;

namespace ShopManagement.Configuration
{
    public class ShopManagementBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddTransient<ICategoryApplication, CategoryApplication>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddTransient<IBookApplication, BookApplication>();
            services.AddTransient<IBookRepository, BookRepository>();

            services.AddTransient<IAuthorApplication, AuthorApplication>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();

            services.AddTransient<IBookCategoryApplication, BookCategoryApplication>();
            services.AddTransient<IBookCategoryRepository, BookCategoryRepository>();

            services.AddTransient<ISlideApplication, SlideApplication>();
            services.AddTransient<ISlideRepository, SlideRepository>();

            services.AddTransient<IQuoteApplication, QuoteApplication>();
            services.AddTransient<IQuoteRepository, QuoteRepository>();

            services.AddTransient<IBannerApplication, BannerApplication>();
            services.AddTransient<IBannerRepository, BannerRepository>();

            services.AddTransient<ISlideQuery, SlideQuery>();
            services.AddTransient<IBookCategoryQuery, BookCategoryQuery>();
            services.AddTransient<IBookCategoryCountQuery, BookCategoryCountQuery>();
            services.AddTransient<IBookQuery, BookQuery>();
            services.AddTransient<IAuthorQuery, AuthorQuery>();
            services.AddTransient<IQuoteQuery, QuoteQuery>();
            services.AddTransient<IBannerQuery, BannerQuery>();

            services.AddDbContext<ShopContext>(x =>
                x.UseSqlServer(connectionString));
        }
    }
}
