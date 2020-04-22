using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;

namespace InventoryService1.Controllers
{
    [Route("v1")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly Services.IInventoryServices _service;

        public InventoryController()
        {
 
        }   

        [HttpPost]
        [Route("AddInventoryItems")]
        public ActionResult<Models.InventoryItems> AddInventoryItems(Models.InventoryItems items)
        {
            var inventoryItems = _service.AddInventoryItems(items);

            if(inventoryItems == null)
            {
                return NotFound();
            }
            return inventoryItems;
        }

        [HttpGet]
        [Route("GetInventoryItems")]
        public ActionResult<Dictionary<string, Models.InventoryItems>> GetInventoryItems()
        {
            var inventoryItems = _service.GetInventoryItems();

            if(inventoryItems.Count == 0)
            {
                return NotFound();
            }
            return inventoryItems;
        }
    }
}