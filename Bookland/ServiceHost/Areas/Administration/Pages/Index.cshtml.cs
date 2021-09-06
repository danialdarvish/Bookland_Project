using System.Collections.Generic;
using System.Linq;
using BooklandReporting.ChartModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public void OnGet()
        {
            var data = _chartQuery.SalesByEachMonth();
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
    }
}
