﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubrania_ASP.NET_Nowy.Models
{
    public class Type
    {
        public int Id { get; set; }
        public int PropertyId { get; set; }
        public string NameOf { get; set; }
        public NamesOfProperty NamesOfProperty { get; set; }
    }
}
