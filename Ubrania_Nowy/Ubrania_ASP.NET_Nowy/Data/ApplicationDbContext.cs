using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ubrania_ASP.NET_Nowy.Models;
using Type = Ubrania_ASP.NET_Nowy.Models.Type;

namespace Ubrania_ASP.NET_Nowy.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Agreement> Agreements { get; set; }
        public DbSet<Cloth> Clothes { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<DailyReport> DailyReports { get; set; }
        public DbSet <MonthlyReport> MonthlyReports { get; set; }
        public DbSet <AnnualReport> AnnualReports { get; set; }
        public DbSet <NamesOfProperty> NamesOfProperties { get; set; }
        public DbSet <Color> Colors { get; set; }
        public DbSet <Mark> Marks { get; set; }
        public DbSet <Size> Sizes { get; set; }
        public DbSet <Type> Types { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Color>().HasData(new Color { Id = 11, NameOf = "Czarny" },
                new Color { Id = 1, NameOf = "Biały" },
                new Color { Id = 2, NameOf = "Różowy" },
                new Color { Id = 3, NameOf = "Czerwony" },
                new Color { Id = 4, NameOf = "Pomarańczowy" },
                new Color { Id = 5, NameOf = "Brązowy" },
                new Color { Id = 6, NameOf = "Żółty" },
                new Color { Id = 7, NameOf = "Szary" },
                new Color { Id = 8, NameOf = "Zielony" },
                new Color { Id = 9, NameOf = "Niebieski" },
                new Color { Id = 10, NameOf = "Fioletowy" });
            builder.Entity<Mark>().HasData(
                new Mark { Id = 1, NameOf = "Zara" },
                new Mark { Id = 2, NameOf = "Hnm" },
                new Mark { Id = 3, NameOf = "Mohito" });
            builder.Entity<Size>().HasData(
                 new Size {Id=1,  NameOf = "xxs" }, 
                 new Size {Id=2,  NameOf = "xs" },
                 new Size {Id=3,  NameOf = "s" }, 
                 new Size {Id=4,  NameOf = "m" }, 
                 new Size {Id=5,  NameOf = "l" }, 
                 new Size {Id=6,  NameOf = "xl" }, 
                 new Size {Id=7,  NameOf = "xxl" }, 
                 new Size {Id=8,  NameOf = "36" }, 
                 new Size {Id=9,  NameOf = "37" }, 
                 new Size {Id=10, NameOf = "38" }, 
                 new Size {Id=11, NameOf = "39" }, 
                 new Size {Id=12, NameOf = "40" }, 
                 new Size {Id=13, NameOf = "41" });
            builder.Entity<Type>().HasData(
                new Type {Id = 1, NameOf = "Biżuteria"},
                new Type {Id=2, NameOf = "Dodatki" },
                new Type {Id=3, NameOf = "Torebka" }, 
                new Type {Id=4, NameOf = "Spodnie" },
                new Type {Id=5, NameOf = "Sukienka" }, 
                new Type {Id=6, NameOf = "Spódnica" }, 
                new Type {Id=7, NameOf = "Kurtka" }, 
                new Type {Id=8, NameOf = "Bluzka" }, 
                new Type {Id=9, NameOf = "Buty" });
           

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Agreement>()
                .HasMany(a => a.Clothes)
                .WithOne(c => c.Agreement)
                .HasForeignKey(c => c.Agreement_Id);
        }

    }
}
