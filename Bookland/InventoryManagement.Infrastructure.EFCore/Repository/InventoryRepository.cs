using System.Collections.Generic;
using System.Linq;
using _01_Framework.Application;
using _01_Framework.Infrastructure;
using AccountManagement.Infrastructure.EFCore;
using InventoryManagement.Application.Contracts.Inventory;
using InventoryManagement.Domain.InventoryAgg;
using ShopManagement.Infrastructure.EFCore;

namespace InventoryManagement.Infrastructure.EFCore.Repository
{
    public class InventoryRepository : RepositoryBase<long, Inventory>, IInventoryRepository
    {
        private readonly ShopContext _shopContext;
        private readonly AccountContext _accountContext;
        private readonly InventoryContext _inventoryContext;

        public InventoryRepository(InventoryContext inventoryContext, ShopContext shopContext, AccountContext accountContext) : base(inventoryContext)
        {
            _shopContext = shopContext;
            _accountContext = accountContext;
            _inventoryContext = inventoryContext;
        }

        public EditInventory GetDetails(long id)
        {
            return _inventoryContext.Inventory.Select(x => new EditInventory
            {
                Id = x.Id,
                BookId = x.BookId,
                UnitPrice = x.UnitPrice
            }).FirstOrDefault(x => x.Id == id);
        }

        public Inventory GetBy(long productId)
        {
            return _inventoryContext.Inventory.FirstOrDefault(x => x.BookId == productId);
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
            var products = _shopContext.Books.Select(x => new { x.Id, x.Name }).ToList();
            var query = _inventoryContext.Inventory.Select(x => new InventoryViewModel
            {
                Id = x.Id,
                UnitPrice = x.UnitPrice,
                BookId = x.BookId,
                InStock = x.InStock,
                CurrentCount = x.CalculateCurrentCount(),
                CreationDate = x.CreationDate.ToFarsi()
            });

            if (searchModel.BookId > 0)
                query = query.Where(x => x.BookId == searchModel.BookId);

            if (searchModel.InStock)
                query = query.Where(x => !x.InStock);



            var inventory = query.OrderByDescending(x => x.Id).ToList();

            inventory.ForEach(item =>
                item.Book = products.FirstOrDefault(x => x.Id == item.BookId)?.Name);

            return inventory;
        }

        public List<InventoryOperationViewModel> GetOperationLog(long inventoryId)
        {
            var accounts = _accountContext.Accounts
                .Select(x => new { x.Id, x.FullName }).ToList();
            var inventory = _inventoryContext.Inventory.FirstOrDefault(x => x.Id == inventoryId);

            var operations = inventory.Operations
                .Select(x => new InventoryOperationViewModel
                {
                    Id = x.Id,
                    Count = x.Count,
                    CurrentCount = x.CurrentCount,
                    Description = x.Description,
                    Operation = x.Operation,
                    OperationDate = x.OperationDate.ToFarsi(),
                    OperatorId = x.OperatorId,
                    OrderId = x.OrderId
                }).OrderByDescending(x => x.Id).ToList();

            foreach (var operation in operations)
            {
                operation.Operator = accounts.FirstOrDefault(x => x.Id == operation.OperatorId)?.FullName;
            }

            return operations;
        }
    }
}
