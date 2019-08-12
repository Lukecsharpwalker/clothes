using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ubrania_ASP.NET_Nowy.Data;
using Ubrania_ASP.NET_Nowy.Models;
using Ubrania_ASP.NET_Nowy.Utility;
using Ubrania_ASP.NET_Nowy.ViewModels;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    [Authorize(Roles = SD.AdminEndUser)]
    public class ClothesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClothesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clothes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Clothes.Include(c => c.Agreement);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Clothes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cloth = await _context.Clothes
                .Include(c => c.Agreement)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cloth == null)
            {
                return NotFound();
            }

            return View(cloth);
        }

        // GET: Clothes/Create
        public IActionResult Create()
        {
            
            ViewData["Agreement_Id"] = new SelectList(_context.Agreements, "Id", "Surname");
            return View();
        }

        // POST: Clothes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Mark,Size,Colour,Type,Description,Price,Price_RL,Agreement_Id,Sold")] Cloth cloth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cloth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Agreement_Id"] = new SelectList(_context.Agreements, "Id", "Name", cloth.Agreement_Id);
            return View(cloth);
        }

        // GET: Clothes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cloth = await _context.Clothes.Include(a=>a.Agreement).SingleOrDefaultAsync(m => m.Id == id);
            if (cloth == null)
            {
                return NotFound();
            }
            return View(cloth);
        }

        // POST: Clothes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Mark,Size,Colour,Type,Description,Price,Price_RL,Agreement_Id,Sold")] Cloth cloth)
        {
            if (id != cloth.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cloth);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClothExists(cloth.Id))
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
            ViewData["Agreement_Id"] = new SelectList(_context.Agreements, "Id", "Name", cloth.Agreement_Id);
            return View(cloth);
        }

        // GET: Clothes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cloth = await _context.Clothes
                .Include(c => c.Agreement)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (cloth == null)
            {
                return NotFound();
            }

            return View(cloth);
        }

        // POST: Clothes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cloth = await _context.Clothes.SingleOrDefaultAsync(m => m.Id == id);
            _context.Clothes.Remove(cloth);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> ReturnCloth(int id)
        {
            var cloth = await _context.Clothes.SingleOrDefaultAsync(m => m.Id == id);
            cloth.Sold = false;
            cloth.Price_RL = 0;
            cloth.SoldDate = default;
            _context.Update(cloth);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> TodayReport()
        {            
            return View(await _context.Clothes.Where(c=>c.SoldDate.Day == DateTime.Now.Day).ToListAsync());
        }

        public IActionResult CustomReport()
        {
            return View();
        }

        // POST: Clothes/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CustomReportDetails(CustomReportViewModel customReportViewModel)
        {
            customReportViewModel.Clothes = await _context.Clothes.Where(c => c.SoldDate >= customReportViewModel.StartDate && c.SoldDate <= customReportViewModel.EndDate).ToListAsync();

            return View(customReportViewModel);
        }



        private bool ClothExists(int id)
        {
            return _context.Clothes.Any(e => e.Id == id);
        }
    }
}
