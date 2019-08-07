using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ubrania_ASP.NET_Nowy.Models
{
    public class Cloth
    {
        public int Id { get; set; }
        public string Mark { get; set; }
        public string Size { get; set; } 
        public string Colour { get; set; } 
        public string Type { get; set; } 
        public string Description { get; set; } 
        public int Price { get; set; }
        public double Price_RL { get; set; }
        public int PriceCounter { get; set; }
        public int Agreement_Id { get; set; }
        public bool Sold { get; set; }
        [DataType(DataType.Date)]
        public DateTime SoldDate { get; set; }
        public string Box { get; set; }
        public Agreement Agreement { get; set; }
    }
}
