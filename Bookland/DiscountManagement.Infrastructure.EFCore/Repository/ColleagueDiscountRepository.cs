﻿using System.Linq;
using System.Collections.Generic;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using DiscountManagement.Application.Contract.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscountAgg;
using ShopManagement.Infrastructure.EFCore;

namespace DiscountManagement.Infrastructure.EFCore.Repository
{
    public class ColleagueDiscountRepository : RepositoryBase<long, ColleagueDiscount>, IColleagueDiscountRepository
    {
        private readonly DiscountContext _context;
        private readonly ShopContext _shopContext;
        public ColleagueDiscountRepository(DiscountContext context, ShopContext shopContext) : base(context)
        {
            _context = context;
            _shopContext = shopContext;
        }

        public EditColleagueDiscount GetDetails(long id)
        {
            return _context.ColleagueDiscounts.Select(x => new EditColleagueDiscount
            {
                Id = x.Id,
                DiscountRate = x.DiscountRate,
                BookId = x.BookId
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel)
        {
            var products = _shopContext.Books.Select(x => new {x.Id, x.Name}).ToList();
            var query = _context.ColleagueDiscounts.Select(x => new ColleagueDiscountViewModel
            {
                Id = x.Id,
                CreationDate = x.CreationDate.ToFarsi(),
                DiscountRate = x.DiscountRate,
                BookId = x.BookId,
                IsRemoved = x.IsRemoved
            });

            if (searchModel.BookId > 0)
                query = query.Where(x => x.BookId == searchModel.BookId);

            var discounts = query
                .OrderByDescending(x => x.Id).ToList();

            discounts.ForEach(discount=>
                discount.Book = products.FirstOrDefault(x=> x.Id == discount.BookId)?.Name);

            return discounts;
        }
    }
}
