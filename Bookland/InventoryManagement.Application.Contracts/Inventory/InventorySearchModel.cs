﻿namespace InventoryManagement.Application.Contracts.Inventory
{
    public class InventorySearchModel
    {
        public long BookId { get; set; }
        public bool InStock { get; set; }
    }
}