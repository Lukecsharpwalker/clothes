using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ubrania_ASP.NET_Nowy.Data;
using Ubrania_ASP.NET_Nowy.Models;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    public class NamesOfPropertiesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NamesOfPropertiesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NamesOfProperties
        public async Task<IActionResult> Index()
        {
            return View(await _context.NamesOfProperties.Include(x=>x.Colors).Include(x=>x.Types).Include(x=>x.Sizes).ToListAsync());
        }

        // GET: NamesOfProperties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var namesOfProperty = await _context.NamesOfProperties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (namesOfProperty == null)
            {
                return NotFound();
            }

            return View(namesOfProperty);
        }

        // GET: NamesOfProperties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NamesOfProperties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id")] NamesOfProperty namesOfProperty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(namesOfProperty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(namesOfProperty);
        }

        // GET: NamesOfProperties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var namesOfProperty = await _context.NamesOfProperties.FindAsync(id);
            if (namesOfProperty == null)
            {
                return NotFound();
            }
            return View(namesOfProperty);
        }

        // POST: NamesOfProperties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id")] NamesOfProperty namesOfProperty)
        {
            if (id != namesOfProperty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(namesOfProperty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NamesOfPropertyExists(namesOfProperty.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(namesOfProperty);
        }

        // GET: NamesOfProperties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var namesOfProperty = await _context.NamesOfProperties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (namesOfProperty == null)
            {
                return NotFound();
            }

            return View(namesOfProperty);
        }

        // POST: NamesOfProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var namesOfProperty = await _context.NamesOfProperties.FindAsync(id);
            _context.NamesOfProperties.Remove(namesOfProperty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NamesOfPropertyExists(int id)
        {
            return _context.NamesOfProperties.Any(e => e.Id == id);
        }
    }
}
