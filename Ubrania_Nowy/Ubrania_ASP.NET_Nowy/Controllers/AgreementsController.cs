using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Ubrania_ASP.NET_Nowy.Data;
using Ubrania_ASP.NET_Nowy.Models;
using Ubrania_ASP.NET_Nowy.Utility;
using Ubrania_ASP.NET_Nowy.ViewModels;

using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Collections.Generic;
using NetBarcode;
using System.Drawing.Drawing2D;
using Ubrania_ASP.NET_Nowy.Models.AgreementClothesCustomerViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ubrania_ASP.NET_Nowy.Controllers
{
    public class AgreementsController : Controller
    {
        private int PageSize = 10;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        public int? pass_id;

        public AgreementsController(
            ApplicationDbContext context,
             UserManager<ApplicationUser> userManager,
             ILogger<AccountController> logger,
             SignInManager<ApplicationUser> signInManager,
             RoleManager<IdentityRole> roleManager
            )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
            _logger = logger;
            _roleManager = roleManager;
        }

        // GET: Agreements
        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Agreements.ToListAsync());
        }

        // GET: Agreements/Details/5
        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements
                .SingleOrDefaultAsync(m => m.Id == id);
            var cloth = await _context.Clothes.Where(m => m.Agreement_Id == id)
                .ToListAsync();
            if (agreement == null)

            {
                return NotFound();
            }
            return View(agreement);

        }

        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> DetailsCustomer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements
                .SingleOrDefaultAsync(m => m.Id == id);
            var cloth = await _context.Clothes.Where(m => m.Agreement_Id == id)
                .ToListAsync();
            if (agreement == null)

            {
                return NotFound();
            }
            return View(agreement);

        }

        // GET: Agreements/Create
        [Authorize(Roles = SD.AdminEndUser)]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Agreements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = SD.AdminEndUser)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Id,Name,Surname,Tel,Pesel,Begin,End")] */Agreement agreement/*, string returnUrl = null*/)
        {
            //ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                agreement.Begin = DateTime.Now;
                agreement.End =  agreement.Begin.AddMonths(2);
                while(agreement.End.DayOfWeek.ToString() != "Thursday")
                {
                    agreement.End = agreement.End.AddDays(1);
                }              

                _context.Add(agreement);
                await _context.SaveChangesAsync();

                var user = new ApplicationUser
                {
                    UserName = agreement.Id.ToString(),
                    Agreement_Id = agreement.Id.ToString(),
                };

                var result = await _userManager.CreateAsync(user, agreement.Pesel.ToString());

                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync(SD.AdminEndUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.AdminEndUser));
                    }

                    if (!await _roleManager.RoleExistsAsync(SD.CustomerEndUser))
                    {
                        await _roleManager.CreateAsync(new IdentityRole(SD.CustomerEndUser));
                    }

                    await _userManager.AddToRoleAsync(user, SD.CustomerEndUser);

                }

                return RedirectToAction(nameof(Index));
            }

            return View(agreement);
        }

        [Authorize(Roles = SD.AdminEndUser)]
        // GET: Agreements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements.SingleOrDefaultAsync(m => m.Id == id);
            if (agreement == null)
            {
                return NotFound();
            }
            return View(agreement);
        }

        // POST: Agreements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = SD.AdminEndUser)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, /*[Bind("Id,Name,Surname,Tel,Pesel,Begin,End")]*/ Agreement agreement)
        {
            if (id != agreement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(agreement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AgreementExists(agreement.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(agreement);
        }

        // GET: Agreements/Delete/5
        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var agreement = await _context.Agreements
                .SingleOrDefaultAsync(m => m.Id == id);
            if (agreement == null)
            {
                return NotFound();
            }

            return View(agreement);
        }

        // POST: Agreements/Delete/5
        [Authorize(Roles = SD.AdminEndUser)]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var agreement = await _context.Agreements.SingleOrDefaultAsync(m => m.Id == id);
            _context.Agreements.Remove(agreement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        //  [HttpPost, ActionName("GoToClothes")]
        //   [ValidateAntiForgeryToken]
        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> GoToClothes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //  var cloth = await _context.Clothes.Where(m => m.Agreement_Id == id).ToListAsync();


            TempData["data1"] = id.ToString();
            return RedirectToAction("Create_Cloth");
            //  return View(cloth);


        }
        [Authorize(Roles = SD.AdminEndUser)]
        public IActionResult Create_Cloth()
        {
            ViewData["Type"] = new SelectList(_context.Types, "Id", "NameOf");
            return View();
        }
        [Authorize(Roles = SD.AdminEndUser)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_Cloth(/*[Bind("Id,Name,Surname,Tel,Pesel,Begin,End")] */Cloth cloth)
        {
            string str;
            str = TempData["data1"].ToString();

            if (ModelState.IsValid)
            {
                cloth.Agreement_Id = Convert.ToInt32(str);
                _context.Add(cloth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create_Cloth));
            }
            return View(cloth);
        }

        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> AgreementClothes(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cloth = await _context.Clothes.Where(m => m.Agreement_Id == id).ToListAsync(); //i think can be changed at include
            var agreement = await _context.Agreements.Where(a => a.Id == id).ToListAsync();
            return View(cloth);
        }

        public async Task<IActionResult> PrintPDF(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var agreement = _context.Agreements.Include(a => a.Clothes).SingleOrDefault(m => m.Id == id);
            return View(agreement);
        }

        [Authorize(Roles = SD.AdminEndUser)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTicket(int? id, TicketViewModel ticketViewModel)
        {
            var clothes = await _context.Clothes.Where(c => c.Agreement_Id == id).ToListAsync();

            foreach (Cloth cloth in clothes)
            {
                cloth.Type = cloth.Type ?? "";
                cloth.Description = cloth.Description ?? "";
                cloth.Mark = cloth.Mark ?? "";
                cloth.Size = cloth.Size ?? "";


                var barcode1 = new Barcode(cloth.Id.ToString(), NetBarcode.Type.Code128, true);
                ticketViewModel.Barcodes.Add(barcode1.GetBase64Image());

                Bitmap bitMapImage = new
                Bitmap(@"C:\Users\jablonskil\Downloads\test.jpg");
                Graphics graphicImage = Graphics.FromImage(bitMapImage);
                graphicImage.SmoothingMode = SmoothingMode.AntiAlias;
                graphicImage.DrawString(cloth.Price.ToString() + "zł",
                new Font("Arial", 30, FontStyle.Italic),
                SystemBrushes.WindowText, new Point(35, 115));
                graphicImage.DrawString(
                    cloth.Type + " " +
                    cloth.Mark + " " +
                    cloth.Description + " " +
                    cloth.Size,
                new Font("Arial", 9, FontStyle.Italic),
                SystemBrushes.WindowText, new Point(1, 205));


                using (var stream = new MemoryStream())
                {
                    bitMapImage.Save(stream, ImageFormat.Bmp);
                    ticketViewModel.Ticket.Add(stream.ToArray());
                }
            }

            return View(ticketViewModel);
        }



        public async Task<IActionResult> AgreementClothesCustomer(int productPage=1)
        {
            var id = HttpContext.User.Identity.Name;

            if (id == null)
            {
                return NotFound();
            }

            AgreementClothesCustomerViewModel ACCVW = new AgreementClothesCustomerViewModel()
            {
               ClothList = new List<Cloth>()
        };
            //  var cloth = await _context.Clothes.Where(m => m.Agreement_Id.ToString() == id).ToListAsync();
            ACCVW.ClothList = await _context.Clothes.Where(m => m.Agreement_Id.ToString() == id).ToListAsync();
            var count = ACCVW.ClothList.Count;
            ACCVW.ClothList = ACCVW.ClothList.OrderBy(m => m.Id).Skip((productPage - 1) * PageSize).Take(PageSize).ToList();

            ACCVW.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItem = count
            };


            return View(ACCVW);
        }

        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> ReturnCloth(int id)
        {
            var cloth = await _context.Clothes.Include(a => a.Agreement).SingleOrDefaultAsync(m => m.Id == id);
            cloth.Sold = false;
            _context.Update(cloth);
            await _context.SaveChangesAsync();
            return RedirectToAction("AgreementClothes", new { id = cloth.Agreement_Id });

        }
        [Authorize(Roles = SD.AdminEndUser)]
        public async Task<IActionResult> DeleteCloth(int id)
        {
            var cloth = await _context.Clothes.Include(a => a.Agreement).SingleOrDefaultAsync(m => m.Id == id);
            _context.Clothes.Remove(cloth);
            await _context.SaveChangesAsync();
            return RedirectToAction("AgreementClothes", new { id = cloth.Agreement_Id });
        }

        public IActionResult CreateClothPartial()
        {

            ViewData["Agreement_Id"] = new SelectList(_context.Agreements, "Id", "Name");
            ViewData["Type"] = new SelectList(_context.Types, "Id", "NameOf");
            return View();
        }

        // POST: Clothes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateClothPartial(Cloth cloth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cloth);
                await _context.SaveChangesAsync();

                return RedirectToAction("AgreementClothes/" + cloth.Agreement_Id);
            }
            ViewData["Agreement_Id"] = new SelectList(_context.Agreements, "Id", "Name", cloth.Agreement_Id);
           return RedirectToAction("AgreementClothes",cloth.Agreement_Id);
        }



        private bool AgreementExists(int id)
        {

            return _context.Agreements.Any(e => e.Id == id);
        }

    }
}
