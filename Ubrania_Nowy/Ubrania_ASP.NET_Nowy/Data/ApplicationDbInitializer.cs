using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Ubrania_ASP.NET_Nowy.Data;
using Ubrania_ASP.NET_Nowy.Models;
using Ubrania_ASP.NET_Nowy.Models.AccountViewModels;
using Ubrania_ASP.NET_Nowy.Services;
using Ubrania_ASP.NET_Nowy.Utility;

namespace Ubrania_ASP.NET_Nowy.Data
{
    public static class ApplicationDbInitializer
    {
        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {

            var user = new ApplicationUser
            {
                UserName = "IgaStaniul",
                Agreement_Id = "IgaStaniul",
            };

            var result = userManager.CreateAsync(user, "!Ptasia1391").Result;
            if (result.Succeeded)
            {
                userManager.AddToRoleAsync(user, SD.AdminEndUser).Wait();
            }
        }
    }
}
