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
        public List<Mark> Marks { get; set; } = new List<Mark>() { new Mark { NameOf = "Zara" }, new Mark { NameOf = "Hnm" }, new Mark { NameOf = "Mohito" } };       
        public List<Size> Sizes { get; set; } = new List<Size> { new Size { NameOf = "xxs" }, new Size { NameOf = "xs" }, new Size { NameOf = "s" },new Size { NameOf = "m" },new Size { NameOf = "l" }, new Size { NameOf = "xl" }, new Size { NameOf = "xxl" }, new Size { NameOf = "36" },new Size { NameOf = "37" }, new Size { NameOf = "38" },new Size { NameOf = "39" }, new Size { NameOf = "40" }, new Size { NameOf = "41" } };
        public List<Color> Colors { get; set; } = new List<Color> { };
        public List<Type> Types { get; set; } = new List<Type> { new Type { NameOf = "Biżuteria" },  new Type { NameOf = "Dodatki" },  new Type { NameOf = "Torebki" }, new Type { NameOf = "Spodnie" }, new Type { NameOf = "Sukienki" },  new Type { NameOf = "Spódnice" },  new Type { NameOf = "Kurtki" },  new Type { NameOf = "Bluzki" },  new Type { NameOf = "Buty" } };

    }
}
