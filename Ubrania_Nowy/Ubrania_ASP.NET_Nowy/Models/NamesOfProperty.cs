using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ubrania_ASP.NET_Nowy.Models
{
    public class NamesOfProperty 
    {
        public int Id { get; set; }
        public IList<Mark> Marks { get; set; }       
        public IList<Size> Sizes { get; set; } 
        public IList<Color> Colors { get; set; } 
        public IList<Type> Types { get; set; } 

    }
}
