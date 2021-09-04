using System.Collections.Generic;
using _01_Framework.Domain;
using ShopManagement.Application.Contracts.Order;

namespace ShopManagement.Domain.OrderAgg
{
    public interface IOrderRepository : IRepository<long, Order>
    {
        double GetAmountBy(long id);
        List<OrderItemViewModel> GetItemsBy(long orderId);
        List<OrderViewModel> Search(OrderSearchModel searchModel);
    }
}
