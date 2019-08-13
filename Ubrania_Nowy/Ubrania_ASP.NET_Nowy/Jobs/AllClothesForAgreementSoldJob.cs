using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Ubrania_ASP.NET_Nowy.Data;

namespace Ubrania_ASP.NET_Nowy.Jobs
{
    public interface IAllClothesForAgreementSoldJob
    {
        Task RunAllClothesForAgreemnetSoldJob();
    }
    public class AllClothesForAgreementSoldJob : IAllClothesForAgreementSoldJob
    {
        private readonly ApplicationDbContext _context;
        public AllClothesForAgreementSoldJob(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task RunAllClothesForAgreemnetSoldJob()
        {
            var clothes = _context.Clothes.ToList();
            var agreements =  _context.Agreements.Where(a=>a.IsActive == true).Include(c=>c.Clothes).ToList();
            

            foreach(var agreement in agreements)
            {
               if(agreement.Clothes != null && !(agreement.Clothes.Select(x => x.Sold).Contains(false)))
                {
                    agreement.IsActive = false;
                    _context.Update(agreement);
                }
            }
            await _context.SaveChangesAsync();
        }
    }
}
