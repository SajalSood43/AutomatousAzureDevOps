using InventoryService1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryService1.Services
{
    interface IInventoryServices
    {
        InventoryItems AddInventoryItems(InventoryItems items);

        Dictionary<string, InventoryItems> GetInventoryItems();    
    }
}
