using System.Collections.Generic;
using BooklandReporting.Query;

namespace BooklandReporting.ChartModels
{
    public interface IChartQuery
    {
        long CountAllOrders();
        long CountAllUsers();
        long CountAllBooks();
        double TotalSales();
        List<SalesChartHelper> SalesByEachMonth();
    }
}
