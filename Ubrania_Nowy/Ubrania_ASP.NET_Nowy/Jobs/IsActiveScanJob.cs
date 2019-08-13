using System;
using System.Linq;
using System.Threading.Tasks;
using Ubrania_ASP.NET_Nowy.Data;

namespace Ubrania_ASP.NET_Nowy.Jobs
{       
    public interface IIsActiveScanJob
    {
        Task RunIsActiveTaskAsync();
    }
    public class IsActiveScanJob : IIsActiveScanJob
    {
        private readonly ApplicationDbContext _context;
        public IsActiveScanJob(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task RunIsActiveTaskAsync()
        {
            var finishedAgreements = _context.Agreements.Where(a => a.End <= DateTime.Now).ToList();

            foreach (var agreement in finishedAgreements)
            {
                agreement.IsActive = false;
                _context.Update(agreement);

            }
            await _context.SaveChangesAsync();
        }
    }
}
