using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Ubrania_ASP.NET_Nowy.Jobs;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    
    public class HangFireController : Controller
    {
        private IIsActiveScanJob _isActiveScanJon;
        private IAllClothesForAgreementSoldJob _allClothesForAgreementSoldJob;
        public HangFireController(IIsActiveScanJob isActiveScanJob, IAllClothesForAgreementSoldJob allClothesForAgreementSoldJob)
        {
            _isActiveScanJon = isActiveScanJob;
            _allClothesForAgreementSoldJob = allClothesForAgreementSoldJob;
        }
        [Route("/IsActive")]
        [HttpGet]
        public IActionResult IsActive()
        {
            RecurringJob.AddOrUpdate("IsActiveJob", () => _isActiveScanJon.RunIsActiveTaskAsync(), Cron.Daily);
            
            return Ok();
        }
        [Route("/AllSold")]
        [HttpGet]
        public IActionResult AllClothesForAgreementSold()
        {
            RecurringJob.AddOrUpdate("AllSold", () => _allClothesForAgreementSoldJob.RunAllClothesForAgreemnetSoldJob(), Cron.Daily);
            return Ok();
        }

    }
}