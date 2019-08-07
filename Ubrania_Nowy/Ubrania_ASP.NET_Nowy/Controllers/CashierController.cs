using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ubrania_ASP.NET_Nowy.Data;
using Ubrania_ASP.NET_Nowy.Models;
using Ubrania_ASP.NET_Nowy.ViewModels;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    public class CashierController : Controller

    {

        private readonly ApplicationDbContext _context;
        public CashierController(
               ApplicationDbContext context
               )
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> TakePrice(ClothViewModel clothViewModel)
        {
            if (clothViewModel.Close == true)
            {

                foreach (var cloth in clothViewModel.ClothList)
                {
                    cloth.Price_RL = (cloth.Price * (1 - (0.01 * clothViewModel.Discount)));
                    cloth.SoldDate = DateTime.Now;
                    _context.Update(cloth);

                }
                await _context.SaveChangesAsync();
                return View("Index");

            }

            if (clothViewModel.Back == "true")
            {
                var priceSubstract = clothViewModel.ClothList.LastOrDefault().Price;
                clothViewModel.ClothList.RemoveAt(clothViewModel.ClothList.Count - 1);
                clothViewModel.PriceCounter -= priceSubstract;
                clothViewModel.Back = "false";
                return View("Index", clothViewModel);

            }


            var SingleCloth = await _context.Clothes.Where(c => c.Id == clothViewModel.Id).SingleOrDefaultAsync();
            if (SingleCloth != null && !(clothViewModel.ClothList.Exists(x => x.Id == SingleCloth.Id)))
            {
                clothViewModel.PriceCounter = SingleCloth.Price + clothViewModel.PriceCounter;

                clothViewModel.ClothList.Add(SingleCloth);

                SingleCloth.Sold = true;


                return View("Index", clothViewModel);
            }
            return View("Index", clothViewModel);

        }
    }
}