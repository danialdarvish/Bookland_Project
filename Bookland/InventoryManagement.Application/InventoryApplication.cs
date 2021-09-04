using System.Collections.Generic;
using _01_Framework.Application;
using InventoryManagement.Application.Contracts.Inventory;
using InventoryManagement.Domain.InventoryAgg;

namespace InventoryManagement.Application
{
    public class InventoryApplication : IInventoryApplication
    {
        private readonly IAuthHelper _authHelper;
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryApplication(IInventoryRepository inventoryRepository, IAuthHelper authHelper)
        {
            _authHelper = authHelper;
            _inventoryRepository = inventoryRepository;
        }


        public OperationResult Create(CreateInventory command)
        {
            var operation = new OperationResult();
            if (_inventoryRepository.Exists(x => x.BookId == command.BookId))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var inventory = new Inventory(command.BookId, command.UnitPrice);
            _inventoryRepository.Create(inventory);
            _inventoryRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Edit(EditInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryRepository.Get(command.Id);
            if (inventory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            if (_inventoryRepository.Exists(x =>
                x.BookId == command.BookId && x.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            inventory.Edit(command.BookId, command.UnitPrice);
            _inventoryRepository.SaveChanges();

            return operation.Succeed();
        }

        public OperationResult Increase(IncreaseInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryRepository.Get(command.InventoryId);

            if (inventory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            const long operatorId = 1;
            inventory.Increase(command.Count, operatorId, command.Description);

            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Reduce(ReduceInventory command)
        {
            var operation = new OperationResult();
            var inventory = _inventoryRepository.Get(command.InventoryId);

            if (inventory == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            var operatorId = _authHelper.CurrentAccountId();
            inventory.Reduce(command.Count, operatorId, command.Description, 0);

            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public OperationResult Reduce(List<ReduceInventory> command)
        {
            var operation = new OperationResult();
            var operatorId = _authHelper.CurrentAccountId();
            foreach (var item in command)
            {
                var inventory = _inventoryRepository.GetBy(item.BookId);
                inventory.Reduce(item.Count, operatorId, item.Description, item.OrderId);

            }
            _inventoryRepository.SaveChanges();
            return operation.Succeed();
        }

        public EditInventory GetDetails(long id)
        {
            return _inventoryRepository.GetDetails(id);
        }

        public List<InventoryViewModel> Search(InventorySearchModel searchModel)
        {
            return _inventoryRepository.Search(searchModel);
        }

        public List<InventoryOperationViewModel> GetOperationLog(long inventoryId)
        {
            return _inventoryRepository.GetOperationLog(inventoryId);
        }
    }
}
