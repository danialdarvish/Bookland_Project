using System;
using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using AccountManagement.Infrastructure.EFCore;
using BooklandReporting.ChartModels;
using ShopManagement.Infrastructure.EFCore;

namespace BooklandReporting.Query
{
    public class ChartQuery : IChartQuery
    {
        private readonly ShopContext _shopContext;
        private readonly AccountContext _accountContext;

        public ChartQuery(AccountContext accountContext, ShopContext shopContext)
        {
            _shopContext = shopContext;
            _accountContext = accountContext;
        }

        public long CountAllOrders()
        {
            return _shopContext.Orders.Count();
        }

        public long CountAllUsers()
        {
            return _accountContext.Accounts.Count();
        }

        public long CountAllBooks()
        {
            return _shopContext.Books.Count();
        }

        public double TotalSales()
        {
            return _shopContext.Orders.Where(x=>x.IsPaid).Sum(x => x.PayAmount);
        }

        public List<SalesChartHelper> SalesByYear(int year)
        {
            #region GroupByCode
            //var orders = _shopContext.Orders.Select(x => new SalesChartHelper
            //{
            //    Year = Convert.ToDateTime(x.CreationDate.ToFarsi()).Year,
            //    Month = Convert.ToDateTime(x.CreationDate.ToFarsi()).Month,
            //    Sale = x.PayAmount
            //}).ToList();
            //var result = orders
            //    .GroupBy(x => new { x.Year, x.Month }, (key, group) => new SalesChartHelper
            //    {
            //        Year = key.Year,
            //        Month = key.Month,
            //        Sale = group.Sum(x => x.Sale)
            //    }).ToList();
            #endregion

            var orders = _shopContext.Orders
                .Where(x => x.IsPaid)
                .Select(x => new SalesChartHelper
                {
                    Year = Convert.ToDateTime(x.CreationDate.ToFarsi()).Year,
                    Month = Convert.ToDateTime(x.CreationDate.ToFarsi()).Month,
                    Sale = x.PayAmount
                }).ToList();

            orders = orders.Where(x => x.Year == year).ToList();

            var result = new List<SalesChartHelper>();
            for (var i = 1; i <= 12; i++)
            {
                result.Add(new SalesChartHelper
                {
                    Month = i,
                    Sale = orders.Where(x => x.Month == i).Sum(x => x.Sale)
                });
            }

            return result;
        }
    }

    public class SalesChartHelper
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public double Sale { get; set; }
    }
}
