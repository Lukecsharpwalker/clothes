using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ubrania_ASP.NET_Nowy.Models;

namespace Ubrania_ASP.NET_Nowy.ViewModels
{
    public class CustomReportViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public IList<Cloth> Clothes { get; set; }
    }
}
