using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    public class ReportsController : Controller
    {
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
        public ActionResult ShowTodayReportData(int id)
        {
            return View();
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