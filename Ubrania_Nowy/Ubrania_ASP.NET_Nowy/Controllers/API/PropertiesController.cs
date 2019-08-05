using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubrania_ASP.NET_Nowy.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    [Route("api/[controller]")]
    public class PropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertiesController(
            ApplicationDbContext context
            )
        {
            _context = context;

        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get(string type, string query = null)
        {
           if(type.Equals("colour") && query!=null)
            {
                var colourQuery = _context.Colors.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                return Ok(colourQuery.ToList());
            }
            if (type.Equals("type") && query != null)
            {
                var typeQuery = _context.Types.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                return Ok(typeQuery.ToList());
            }
            if (type.Equals("mark") && query != null)
            {
                var markQuery = _context.Marks.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                return Ok(markQuery.ToList());
            }
            if (type.Equals("size") && query != null)
            {
                var sizeQuery = _context.Sizes.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                return Ok(sizeQuery.ToList());
            }
            return Ok();

        }


    }
}
