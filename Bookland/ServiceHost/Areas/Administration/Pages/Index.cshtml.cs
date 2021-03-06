using _01_Framework.Application;
using BooklandReporting.ChartModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using _01_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Areas.Administration.Pages
{
    public class IndexModel : PageModel
    {
        public long AllOrderCount { get; set; }
        public long UsersCount { get; set; }
        public long BooksCount { get; set; }
        public double TotalSale { get; set; }

        public List<Chart> DataSet { get; set; }

        private readonly IChartQuery _chartQuery;

        public IndexModel(IChartQuery chartQuery)
        {
            _chartQuery = chartQuery;
        }

        
        public void OnGet(int year)
        {
            if (year == 0)
                year = Convert.ToDateTime(DateTime.Now.ToFarsi()).Year;

            var data = _chartQuery.SalesByYear(year);
            DataSet = new List<Chart>
            {
                new Chart
                {
                    Data = data.Select(x=>x.Sale).ToList(),
                    Label = "میزان فروش",
                    BackgroundColor = "#38b000",
                    BorderColor = "#008000"
                }
            };
            BooksCount = _chartQuery.CountAllBooks();
            UsersCount = _chartQuery.CountAllUsers();
            TotalSale = _chartQuery.TotalSales();
            AllOrderCount = _chartQuery.CountAllOrders();
        }

        public IActionResult OnGetLoadChart(int year)
        {
            if (year == 0)
                year = Convert.ToDateTime(DateTime.Now.ToFarsi()).Year;

            var data = _chartQuery.SalesByYear(year);
            DataSet = new List<Chart>
            {
                new Chart
                {
                    Data = data.Select(x=>x.Sale).ToList(),
                    Label = "میزان فروش",
                    BackgroundColor = "#38b000",
                    BorderColor = "#008000"
                }
            };

            var chartData = DataSet;
            return new JsonResult(chartData);
        }
    }
}
