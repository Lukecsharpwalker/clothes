using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Ubrania_ASP.NET_Nowy.ViewModels
{
    public class TicketViewModel
    {
        public List<byte[]> Barcodes { get; set; } = new List<byte[]>();
    }
}
