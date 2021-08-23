using System;
using System.Collections.Generic;
using System.Linq;
using _01_BooklandQuery.Contract.Banner;
using _01_Framework.Application;
using DiscountManagement.Infrastructure.EFCore;
using InventoryManagement.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;
using ShopManagement.Infrastructure.EFCore;

namespace _01_BooklandQuery.Query
{
    public class BannerQuery : IBannerQuery
    {
        private readonly ShopContext _shopContext;
        private readonly DiscountContext _discountContext;
        private readonly InventoryContext _inventoryContext;

        public BannerQuery(ShopContext shopContext, DiscountContext discountContext,
            InventoryContext inventoryContext)
        {
            _shopContext = shopContext;
            _discountContext = discountContext;
            _inventoryContext = inventoryContext;
        }


        public BannerQueryModel GetBanner()
        {
            var inventory = _inventoryContext.Inventory
                .Select(x => new { x.BookId, x.UnitPrice, x.InStock }).ToList();

            var discounts = _discountContext.CustomerDiscounts
                .Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now)
                .Select(x => new { x.BookId, x.DiscountRate, x.EndDate });

            var banner = _shopContext.Banners
                .Include(x => x.Book)
                .ThenInclude(x => x.Author)
                .Select(x => new BannerQueryModel
                {
                    Id = x.Id,
                    BookName = x.Book.Name,
                    AuthorName = x.Book.Author.FullName,
                    Picture = x.Picture,
                    PictureAlt = x.PictureAlt,
                    PictureTitle = x.PictureTitle,
                    Tag = x.Tag,
                    BookId = x.BookId,
                    BookSlug = x.Book.Slug
                }).AsNoTracking().AsEnumerable().Shuffle().Take(1).SingleOrDefault();

            if (banner == null) return new BannerQueryModel();

            var bookInventory = inventory
                .FirstOrDefault(x => x.BookId == banner.BookId);
            if (bookInventory != null)
            {
                banner.IsInStock = bookInventory.InStock;
                var price = bookInventory.UnitPrice;
                banner.Price = price.ToMoney();
                banner.DoublePrice = price;

                var discount = discounts
                    .FirstOrDefault(x => x.BookId == banner.BookId);
                if (discount != null)
                {
                    var discountRate = discount.DiscountRate;
                    banner.DiscountRate = discountRate;
                    banner.HasDiscount = discountRate > 0;

                    var discountAmount = Math.Round(price * discountRate / 100);
                    banner.PriceWithDiscount = (price - discountAmount).ToMoney();
                }
            }

            return banner;
        }
    }
}
