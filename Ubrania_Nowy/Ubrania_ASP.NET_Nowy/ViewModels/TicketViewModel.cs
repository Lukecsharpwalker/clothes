using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace Ubrania_ASP.NET_Nowy.ViewModels
{
    public class TicketViewModel
    {
        public List<string> Barcodes { get; set; } = new List<string>();
        public List<byte[]> Ticket { get; set; } = new List<byte[]>();
    }
}
