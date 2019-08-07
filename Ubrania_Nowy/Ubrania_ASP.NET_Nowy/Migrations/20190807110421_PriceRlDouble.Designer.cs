﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ubrania_ASP.NET_Nowy.Data;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190807110421_PriceRlDouble")]
    partial class PriceRlDouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Agreement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Begin");

                    b.Property<DateTime>("End");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<double>("Pesel");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<double>("Tel");

                    b.HasKey("Id");

                    b.ToTable("Agreements");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.AnnualReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balance");

                    b.Property<DateTime>("Year");

                    b.HasKey("Id");

                    b.ToTable("AnnualReports");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Agreement_Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Pesel");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Cloth", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Agreement_Id");

                    b.Property<int?>("AnnualReportId");

                    b.Property<string>("Box");

                    b.Property<string>("Colour");

                    b.Property<int?>("DailyReportId");

                    b.Property<string>("Description");

                    b.Property<string>("Mark");

                    b.Property<int?>("MonthlyReportId");

                    b.Property<int>("Price");

                    b.Property<int>("PriceCounter");

                    b.Property<double>("Price_RL");

                    b.Property<string>("Size");

                    b.Property<bool>("Sold");

                    b.Property<DateTime>("SoldDate");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("Agreement_Id");

                    b.HasIndex("AnnualReportId");

                    b.HasIndex("DailyReportId");

                    b.HasIndex("MonthlyReportId");

                    b.ToTable("Clothes");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Colour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOf");

                    b.Property<int>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Colors");

                    b.HasData(
                        new { Id = 11, NameOf = "Czarny", PropertyId = 1 },
                        new { Id = 1, NameOf = "Biały", PropertyId = 1 },
                        new { Id = 2, NameOf = "Różowy", PropertyId = 1 },
                        new { Id = 3, NameOf = "Czerwony", PropertyId = 1 },
                        new { Id = 4, NameOf = "Pomarańczowy", PropertyId = 1 },
                        new { Id = 5, NameOf = "Brązowy", PropertyId = 1 },
                        new { Id = 6, NameOf = "Żółty", PropertyId = 1 },
                        new { Id = 7, NameOf = "Szary", PropertyId = 1 },
                        new { Id = 8, NameOf = "Zielony", PropertyId = 1 },
                        new { Id = 9, NameOf = "Niebieski", PropertyId = 1 },
                        new { Id = 10, NameOf = "Fioletowy", PropertyId = 1 }
                    );
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.DailyReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balance");

                    b.Property<DateTime>("Day");

                    b.HasKey("Id");

                    b.ToTable("DailyReports");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOf");

                    b.Property<int>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Marks");

                    b.HasData(
                        new { Id = 1, NameOf = "Zara", PropertyId = 1 },
                        new { Id = 2, NameOf = "Hnm", PropertyId = 1 },
                        new { Id = 3, NameOf = "Mohito", PropertyId = 1 }
                    );
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.MonthlyReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Balance");

                    b.Property<DateTime>("Month");

                    b.HasKey("Id");

                    b.ToTable("MonthlyReports");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.NamesOfProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("NamesOfProperties");

                    b.HasData(
                        new { Id = 1 }
                    );
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOf");

                    b.Property<int>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Sizes");

                    b.HasData(
                        new { Id = 1, NameOf = "xxs", PropertyId = 1 },
                        new { Id = 2, NameOf = "xs", PropertyId = 1 },
                        new { Id = 3, NameOf = "s", PropertyId = 1 },
                        new { Id = 4, NameOf = "m", PropertyId = 1 },
                        new { Id = 5, NameOf = "l", PropertyId = 1 },
                        new { Id = 6, NameOf = "xl", PropertyId = 1 },
                        new { Id = 7, NameOf = "xxl", PropertyId = 1 },
                        new { Id = 8, NameOf = "36", PropertyId = 1 },
                        new { Id = 9, NameOf = "37", PropertyId = 1 },
                        new { Id = 10, NameOf = "38", PropertyId = 1 },
                        new { Id = 11, NameOf = "39", PropertyId = 1 },
                        new { Id = 12, NameOf = "40", PropertyId = 1 },
                        new { Id = 13, NameOf = "41", PropertyId = 1 }
                    );
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOf");

                    b.Property<int>("PropertyId");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Types");

                    b.HasData(
                        new { Id = 1, NameOf = "Biżuteria", PropertyId = 1 },
                        new { Id = 2, NameOf = "Dodatki", PropertyId = 1 },
                        new { Id = 3, NameOf = "Torebka", PropertyId = 1 },
                        new { Id = 4, NameOf = "Spodnie", PropertyId = 1 },
                        new { Id = 5, NameOf = "Sukienka", PropertyId = 1 },
                        new { Id = 6, NameOf = "Spódnica", PropertyId = 1 },
                        new { Id = 7, NameOf = "Kurtka", PropertyId = 1 },
                        new { Id = 8, NameOf = "Bluzka", PropertyId = 1 },
                        new { Id = 9, NameOf = "Buty", PropertyId = 1 }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Cloth", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.Agreement", "Agreement")
                        .WithMany("Clothes")
                        .HasForeignKey("Agreement_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.AnnualReport")
                        .WithMany("Clothes")
                        .HasForeignKey("AnnualReportId");

                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.DailyReport")
                        .WithMany("Clothes")
                        .HasForeignKey("DailyReportId");

                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.MonthlyReport")
                        .WithMany("Clothes")
                        .HasForeignKey("MonthlyReportId");
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Colour", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.NamesOfProperty", "NamesOfProperty")
                        .WithMany("Colors")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Mark", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.NamesOfProperty", "NamesOfProperty")
                        .WithMany("Marks")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Size", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.NamesOfProperty", "NamesOfProperty")
                        .WithMany("Sizes")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Ubrania_ASP.NET_Nowy.Models.Type", b =>
                {
                    b.HasOne("Ubrania_ASP.NET_Nowy.Models.NamesOfProperty", "NamesOfProperty")
                        .WithMany("Types")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
