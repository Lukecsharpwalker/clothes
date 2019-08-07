using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ubrania_ASP.NET_Nowy.Models.AgreementClothesCustomerViewModel
{
    public class AgreementClothesCustomerViewModel
    {
        public IList<Cloth> ClothList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
