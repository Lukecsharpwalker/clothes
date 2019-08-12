using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ubrania_ASP.NET_Nowy.Data;

namespace Ubrania_ASP.NET_Nowy.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class NamesListController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NamesListController(
            ApplicationDbContext context
            )
        {
            _context = context;
        }
        // GET: api/NamesList
        [HttpGet]
        public IActionResult Get(string type, string query = null)
        {
            var namesListQuery = _context.Colors.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
            return Ok(namesListQuery.ToList());
        }
        
    }
}
