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
        public List<Mark> Marks { get; set; } = new List<Mark>() {  };       
        public List<Size> Sizes { get; set; } = new List<Size> { };
        public List<Color> Colors { get; set; } = new List<Color> { };
        public List<Type> Types { get; set; } = new List<Type> { };

    }
}
