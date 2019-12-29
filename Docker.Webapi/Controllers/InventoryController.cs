using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Docker.Webapi.Infrastructure;
using Docker.Webapi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Docker.Webapi.Controllers
{
    [ApiController]
    [Route("api/inventory")]
    public class InventoryController : ControllerBase
    {
        private readonly WebApiDbContext _context;

        public InventoryController(WebApiDbContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public ActionResult<IEnumerable<Inventory>> GetAllInventories()
        {
            var inventories = _context.Inventory.ToList();
            return Ok(inventories);
        }
    }
}