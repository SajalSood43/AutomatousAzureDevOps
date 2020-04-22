using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService1.Services
{
    public class InventoryService : IInventoryServices
    {
        private readonly Dictionary<string, Models.InventoryItems> _inventoryItems;

        public InventoryService()
        {
            _inventoryItems = new Dictionary<string, Models.InventoryItems>();
        }
       
        public Models.InventoryItems AddInventoryItems(Models.InventoryItems items)
        {
            _inventoryItems.Add(items.ItemName, items);

            return items;
        }

        public Dictionary<string, Models.InventoryItems> GetInventoryItems()
        {
            return _inventoryItems;
        }
    }
}
