using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ubrania_ASP.NET_Nowy.Data;
using Ubrania_ASP.NET_Nowy.Models;
using Ubrania_ASP.NET_Nowy.Utility;
using Ubrania_ASP.NET_Nowy.ViewModels;

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
            switch (type)
            {
                case "colour":
                    var colourQuery = _context.Colors.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                    return Ok(colourQuery.ToList());
                case "type":
                    var typeQuery = _context.Types.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                    return Ok(typeQuery.ToList());
                case "mark":
                    var markQuery = _context.Marks.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                    return Ok(markQuery.ToList());
                case "size":
                    var sizeQuery = _context.Sizes.Where(c => c.NameOf.ToLower().Contains(query.ToLower()));
                    return Ok(sizeQuery.ToList());
                default:
                    return Ok();

            }

        }             

    }
}
