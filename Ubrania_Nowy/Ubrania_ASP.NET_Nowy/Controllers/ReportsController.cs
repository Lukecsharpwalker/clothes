using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ubrania_ASP.NET_Nowy.Data;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    public class ReportsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReportsController(
            ApplicationDbContext context
            )
        {
            _context = context;
        }
        public ActionResult GetDailyReportData()
        {
            return View();
        }
        public ActionResult ShowDailyReportData(int id)
        {
            return View();
        }
        ////////////////////////////////////
        public ActionResult GetMonthlyReportData()
        {
            return View();
        }
        public ActionResult ShowMonthlyReportData(int id)
        {
            return View();
        }
        ////////////////////////////////////
        public ActionResult GetAnnualReportData()
        {
            return View();
        }
        public ActionResult ShowAnnualReportData(int id)
        {
            return View();
        }
        ////////////////////////////////////
        public ActionResult GetTodayReportData()
        {
            return View();
        }
        public async Task<IActionResult> ShowTodayReportData()
        {
            var todaySoldClothes = await _context.Clothes.Where(c => c.SoldDate.Day == DateTime.Now.Day).ToListAsync();
            return View(todaySoldClothes);
        }
        ////////////////////////////////////
        public ActionResult GetCustomReportData()
        {
            return View();
        }
        public ActionResult ShowCustomReportData(int id)
        {
            return View();
        }

    }
}