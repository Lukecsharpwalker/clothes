using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Ubrania_ASP.NET_Nowy.Models;
using Ubrania_ASP.NET_Nowy.Utility;
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
        public DbSet<MonthlyReport> MonthlyReports { get; set; }
        public DbSet<AnnualReport> AnnualReports { get; set; }
        public DbSet<NamesOfProperty> NamesOfProperties { get; set; }
        public DbSet<Colour> Colors { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<NamesList> NamesLists { get; set; }
        public DbSet<LastnamesList> LastnamesLists { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = SD.AdminEndUser, NormalizedName = SD.AdminEndUser.ToUpper() });
            builder.Entity<NamesOfProperty>().HasData(
                new NamesOfProperty { Id = 1 });
            builder.Entity<Colour>().HasData(
                new Colour { PropertyId = 1, Id = 11, NameOf = "Czarny" },
                new Colour { PropertyId = 1, Id = 1, NameOf = "Biały" },
                new Colour { PropertyId = 1, Id = 2, NameOf = "Różowy" },
                new Colour { PropertyId = 1, Id = 3, NameOf = "Czerwony" },
                new Colour { PropertyId = 1, Id = 4, NameOf = "Pomarańczowy" },
                new Colour { PropertyId = 1, Id = 5, NameOf = "Brązowy" },
                new Colour { PropertyId = 1, Id = 6, NameOf = "Żółty" },
                new Colour { PropertyId = 1, Id = 7, NameOf = "Szary" },
                new Colour { PropertyId = 1, Id = 8, NameOf = "Zielony" },
                new Colour { PropertyId = 1, Id = 9, NameOf = "Niebieski" },
                new Colour { PropertyId = 1, Id = 10, NameOf = "Fioletowy" });
            builder.Entity<Mark>().HasData(
                new Mark { PropertyId = 1, Id = 1, NameOf = "Zara" },
                new Mark { PropertyId = 1, Id = 2, NameOf = "Hnm" },
                new Mark { PropertyId = 1, Id = 3, NameOf = "Mohito" });
            builder.Entity<Size>().HasData(
                 new Size { PropertyId = 1, Id = 1, NameOf = "xxs" },
                 new Size { PropertyId = 1, Id = 2, NameOf = "xs" },
                 new Size { PropertyId = 1, Id = 3, NameOf = "s" },
                 new Size { PropertyId = 1, Id = 4, NameOf = "m" },
                 new Size { PropertyId = 1, Id = 5, NameOf = "l" },
                 new Size { PropertyId = 1, Id = 6, NameOf = "xl" },
                 new Size { PropertyId = 1, Id = 7, NameOf = "xxl" },
                 new Size { PropertyId = 1, Id = 8, NameOf = "36" },
                 new Size { PropertyId = 1, Id = 9, NameOf = "37" },
                 new Size { PropertyId = 1, Id = 10, NameOf = "38" },
                 new Size { PropertyId = 1, Id = 11, NameOf = "39" },
                 new Size { PropertyId = 1, Id = 12, NameOf = "40" },
                 new Size { PropertyId = 1, Id = 13, NameOf = "41" });
            builder.Entity<Type>().HasData(
                new Type { PropertyId = 1, Id = 1, NameOf = "Biżuteria" },
                new Type { PropertyId = 1, Id = 2, NameOf = "Dodatki" },
                new Type { PropertyId = 1, Id = 3, NameOf = "Torebka" },
                new Type { PropertyId = 1, Id = 4, NameOf = "Spodnie" },
                new Type { PropertyId = 1, Id = 5, NameOf = "Sukienka" },
                new Type { PropertyId = 1, Id = 6, NameOf = "Spódnica" },
                new Type { PropertyId = 1, Id = 7, NameOf = "Kurtka" },
                new Type { PropertyId = 1, Id = 8, NameOf = "Bluzka" },
                new Type { PropertyId = 1, Id = 9, NameOf = "Buty" });

            //using (StreamReader r = new StreamReader(@"C:\Temp\NamesList.json"))
            //{
            //    string json = r.ReadToEnd();
            //    var items = JsonConvert.DeserializeObject<List<NamesList>>(json);
            //    items.RemoveAt(0);
            //    builder.Entity<NamesList>().HasData(items.ToArray());
            //}
                    

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Agreement>()
                .HasMany(a => a.Clothes)
                .WithOne(c => c.Agreement)
                .HasForeignKey(c => c.Agreement_Id);
            builder.Entity<NamesOfProperty>()
                .HasMany(m => m.Marks)
                .WithOne(n => n.NamesOfProperty)
                .HasForeignKey(k => k.PropertyId);
            builder.Entity<NamesOfProperty>()
                .HasMany(m => m.Colors)
                .WithOne(n => n.NamesOfProperty)
                .HasForeignKey(k => k.PropertyId);
            builder.Entity<NamesOfProperty>()
                .HasMany(m => m.Sizes)
                .WithOne(n => n.NamesOfProperty)
                .HasForeignKey(k => k.PropertyId);
            builder.Entity<NamesOfProperty>()
                .HasMany(m => m.Types)
                .WithOne(n => n.NamesOfProperty)
                .HasForeignKey(k => k.PropertyId);

        }

    }
}
