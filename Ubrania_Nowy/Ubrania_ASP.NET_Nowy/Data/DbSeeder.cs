using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Ubrania_ASP.NET_Nowy.Data
{
    public static class DbSeeder
    {
        public static void SeedDb(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            context.Database.EnsureCreated();


            IdentityUser user = new IdentityUser
            {
                UserName = "x@x.p",
                Email = "x@x.p"
            };

            userManager.CreateAsync(user, "pass").Wait();

        }
    }
}
