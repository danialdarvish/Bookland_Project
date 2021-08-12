﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement.Application;
using ShopManagement.Application.Contracts.Author;
using ShopManagement.Application.Contracts.Book;
using ShopManagement.Application.Contracts.BookCategory;
using ShopManagement.Application.Contracts.Category;
using ShopManagement.Domain.AuthorAgg;
using ShopManagement.Domain.BookAgg;
using ShopManagement.Domain.BookCategoryAgg;
using ShopManagement.Domain.CategoryAgg;
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

            services.AddDbContext<ShopContext>(x =>
                x.UseSqlServer(connectionString));
        }
    }
}
