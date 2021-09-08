using System;
using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using BooklandReporting.ChartModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Areas.Administration.Pages
{
    public class ChartModel : PageModel
    {
        public List<Chart> DataSet { get; set; }
        public List<Chart> Up { get; set; }

        private readonly IChartQuery _chartQuery;

        public ChartModel(IChartQuery chartQuery)
        {
            _chartQuery = chartQuery;
        }

        public IActionResult OnGet(int year)
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

            return new JsonResult(DataSet);
        }
    }
}
