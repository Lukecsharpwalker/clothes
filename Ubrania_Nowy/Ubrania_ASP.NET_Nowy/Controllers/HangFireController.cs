using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Ubrania_ASP.NET_Nowy.Jobs;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    [Route("/IsActive")]
    public class HangFireController : Controller
    {
        private IIsActiveScanJob _isActiveScanJon;
        public HangFireController(IIsActiveScanJob isActiveScanJob)
        {
            _isActiveScanJon = isActiveScanJob;
        }
        [HttpGet]
        public IActionResult Index()
        {
            RecurringJob.AddOrUpdate("IsActiveJob", () => _isActiveScanJon.RunIsActiveTaskAsync(), Cron.Daily);
            
            return Ok();
        }
    }
}