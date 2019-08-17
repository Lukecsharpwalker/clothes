using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Tel = table.Column<double>(nullable: false),
                    Pesel = table.Column<double>(nullable: false),
                    Begin = table.Column<DateTime>(nullable: false),
                    End = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnnualReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Agreement_Id = table.Column<string>(nullable: true),
                    Pesel = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Day = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LastnamesLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Lastname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastnamesLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Month = table.Column<DateTime>(nullable: false),
                    Balance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NamesLists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamesLists", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NamesOfProperties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NamesOfProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clothes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mark = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Price_RL = table.Column<double>(nullable: false),
                    Agreement_Id = table.Column<int>(nullable: false),
                    Sold = table.Column<bool>(nullable: false),
                    SoldDate = table.Column<DateTime>(nullable: false),
                    Box = table.Column<string>(nullable: true),
                    AnnualReportId = table.Column<int>(nullable: true),
                    DailyReportId = table.Column<int>(nullable: true),
                    MonthlyReportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clothes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clothes_Agreements_Agreement_Id",
                        column: x => x.Agreement_Id,
                        principalTable: "Agreements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clothes_AnnualReports_AnnualReportId",
                        column: x => x.AnnualReportId,
                        principalTable: "AnnualReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clothes_DailyReports_DailyReportId",
                        column: x => x.DailyReportId,
                        principalTable: "DailyReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clothes_MonthlyReports_MonthlyReportId",
                        column: x => x.MonthlyReportId,
                        principalTable: "MonthlyReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyId = table.Column<int>(nullable: false),
                    NameOf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_NamesOfProperties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyId = table.Column<int>(nullable: false),
                    NameOf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_NamesOfProperties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyId = table.Column<int>(nullable: false),
                    NameOf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_NamesOfProperties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PropertyId = table.Column<int>(nullable: false),
                    NameOf = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_NamesOfProperties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7930229a-e0f4-4b9f-9784-2b5ee826060d", "e7a7f716-7d5f-41a3-9163-f1465d719c34", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "NamesLists",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 384, "Nikola" },
                    { 383, "Nikodema" },
                    { 382, "Nika" },
                    { 381, "Nela" },
                    { 380, "Natasza" },
                    { 379, "Natalia" },
                    { 378, "Narcyza" },
                    { 377, "Najsława" },
                    { 376, "Najmiła" },
                    { 375, "Nadzieja" },
                    { 374, "Nadia" },
                    { 373, "Morzena" },
                    { 372, "Morzana" },
                    { 371, "Monika" },
                    { 370, "Mojmira" },
                    { 369, "Mirosława" },
                    { 368, "Mirołada" },
                    { 354, "Mieczysława" },
                    { 355, "Milena" },
                    { 356, "Milomira" },
                    { 357, "Miłosława" },
                    { 358, "Miłowita" },
                    { 359, "Minerwa" },
                    { 385, "Nikita" },
                    { 360, "Mina" },
                    { 362, "Mirabela" },
                    { 363, "Miranda" },
                    { 364, "Mirela" },
                    { 365, "Miriam" },
                    { 366, "Mirka" },
                    { 367, "Miroda" },
                    { 361, "Mira" },
                    { 353, "Michalina" },
                    { 386, "Nikoleta" },
                    { 388, "Noemi" },
                    { 419, "Przemysława" },
                    { 418, "Polmira" },
                    { 417, "Pola" },
                    { 416, "Placyda" },
                    { 415, "Petronia" },
                    { 414, "Petronela" },
                    { 413, "Petra" },
                    { 412, "Pelagia" },
                    { 411, "Paulina" },
                    { 410, "Paula" },
                    { 409, "Patrycja" },
                    { 408, "Pamela" },
                    { 407, "Pabiana" },
                    { 406, "Olena" },
                    { 405, "Ożanna" },
                    { 404, "Otylia" },
                    { 403, "Ota" },
                    { 389, "Nora" },
                    { 390, "Norberta" },
                    { 391, "Norma" },
                    { 392, "Oda" },
                    { 393, "Odeta" },
                    { 394, "Odyla" },
                    { 387, "Nina" },
                    { 395, "Ofelia" },
                    { 397, "Oktawia" },
                    { 398, "Ola" },
                    { 399, "Olga" },
                    { 400, "Olimpia" },
                    { 401, "Oliwia" },
                    { 402, "Oriana" },
                    { 396, "Oksana" },
                    { 352, "Melania" },
                    { 351, "Matylda" },
                    { 350, "Marzena" },
                    { 313, "Ludmiła" },
                    { 312, "Lucyna" },
                    { 311, "Lucjola" },
                    { 310, "Lucjana" },
                    { 309, "Luborada" },
                    { 308, "Lora" },
                    { 307, "Liwia" },
                    { 306, "Linda" },
                    { 305, "Liliana" },
                    { 304, "Lilia" },
                    { 303, "Ligia" },
                    { 302, "Lidia" },
                    { 301, "Leopolda" },
                    { 300, "Leonora" },
                    { 299, "Leoncja" },
                    { 298, "Leonarda" },
                    { 297, "Leona" },
                    { 283, "Kwiatosława" },
                    { 284, "Kwietosława" },
                    { 285, "Laila" },
                    { 286, "Lajla" },
                    { 287, "Lana" },
                    { 288, "Larisa" },
                    { 314, "Ludolfa" },
                    { 289, "Larysa" },
                    { 291, "Laura" },
                    { 292, "Laurenjca" },
                    { 293, "Lea" },
                    { 294, "Lejla" },
                    { 295, "Lena" },
                    { 296, "Leokadia" },
                    { 290, "Latifa" },
                    { 315, "Ludwika" },
                    { 316, "Ludwina" },
                    { 317, "Luiza" },
                    { 336, "Marcjana" },
                    { 337, "Marcjanna" },
                    { 338, "Maria" },
                    { 339, "Mariam" },
                    { 340, "Marianna" },
                    { 341, "Marietta" },
                    { 335, "Marcelina" },
                    { 342, "Marika" },
                    { 344, "Marlena" },
                    { 345, "Marta" },
                    { 346, "Martyna" },
                    { 347, "Maryja" },
                    { 348, "Maryla" },
                    { 349, "Maryna" },
                    { 343, "Mariola" },
                    { 420, "Przybysława" },
                    { 334, "Marcela" },
                    { 332, "Małgorzata" },
                    { 318, "Luna" },
                    { 319, "Lilianna" },
                    { 320, "Ładana" },
                    { 321, "Ładysława" },
                    { 322, "Łagoda" },
                    { 323, "Łucja" },
                    { 333, "Manuela" },
                    { 324, "Macieja" },
                    { 326, "Magdalena" },
                    { 327, "Maja" },
                    { 328, "Maksa" },
                    { 329, "Maksyma" },
                    { 330, "Malina" },
                    { 331, "Malwina" },
                    { 325, "Magda" },
                    { 282, "Kunegunda" },
                    { 421, "Rachela" },
                    { 423, "Radmiła" },
                    { 525, "Wiara" },
                    { 524, "Wesna" },
                    { 523, "Weronika" },
                    { 522, "Wera" },
                    { 521, "Wanessa" },
                    { 520, "Wanda" },
                    { 519, "Waleria" },
                    { 518, "Walentyna" },
                    { 517, "Wacława" },
                    { 516, "Uta" },
                    { 515, "Urszula" },
                    { 514, "Unima" },
                    { 513, "Una" },
                    { 512, "Uma" },
                    { 511, "Ulryka" },
                    { 510, "Ulana" },
                    { 509, "Tessa" },
                    { 495, "Tadea" },
                    { 496, "Tamara" },
                    { 497, "Tatiana" },
                    { 498, "Tekla" },
                    { 499, "Telimena" },
                    { 500, "Teodora" },
                    { 526, "Wielina" },
                    { 501, "Teodozja" },
                    { 503, "Tęgomira" },
                    { 504, "Tina" },
                    { 505, "Tolisława" },
                    { 506, "Tomiła" },
                    { 507, "Tomisława" },
                    { 508, "Tulimira" },
                    { 502, "Teresa" },
                    { 494, "Tacjana" },
                    { 527, "Wiera" },
                    { 529, "Wiesława" },
                    { 560, "Żywia" },
                    { 559, "Żużanna" },
                    { 558, "Żelisława" },
                    { 557, "Żanna" },
                    { 556, "Żaneta" },
                    { 555, "Żaklina" },
                    { 554, "Zyta" },
                    { 553, "Zygfryda" },
                    { 552, "Zwinisława" },
                    { 551, "Zuzanna" },
                    { 550, "Zoja" },
                    { 549, "Zofia" },
                    { 548, "Zenona" },
                    { 547, "Zenobia" },
                    { 546, "Zefiryna" },
                    { 545, "Zdzisława" },
                    { 544, "Zaira" },
                    { 530, "Wiktoria" },
                    { 531, "Wilhelmina" },
                    { 532, "Wilma" },
                    { 533, "Wincentyna" },
                    { 534, "Wioleta" },
                    { 535, "Wirgilia" },
                    { 528, "Wierada" },
                    { 536, "Wirginia" },
                    { 538, "Witosława" },
                    { 539, "Władysława" },
                    { 540, "Włodzimiera" },
                    { 541, "Wolimira" },
                    { 542, "Wrocisława" },
                    { 543, "Zaida" },
                    { 537, "Wisława" },
                    { 493, "Tabita" },
                    { 492, "Świętosława" },
                    { 491, "Świętomira" },
                    { 454, "Saloma" },
                    { 453, "Salma" },
                    { 452, "Safira" },
                    { 451, "Sabina" },
                    { 450, "Ryszarda" },
                    { 449, "Ruta" },
                    { 448, "Rudolfina" },
                    { 447, "Róża" },
                    { 446, "Rozwita" },
                    { 445, "Rozetta" },
                    { 444, "Rozamunda" },
                    { 443, "Rozalinda" },
                    { 442, "Rozalia" },
                    { 441, "Romualda" },
                    { 440, "Romana" },
                    { 439, "Roma" },
                    { 438, "Roksana" },
                    { 424, "Radomiła" },
                    { 425, "Radomira" },
                    { 426, "Radosława" },
                    { 427, "Rafaela" },
                    { 428, "Rajmunda" },
                    { 429, "Rajna" },
                    { 455, "Salomea" },
                    { 430, "Raszyda" },
                    { 432, "Regina" },
                    { 433, "Remigia" },
                    { 434, "Renata" },
                    { 435, "Rita" },
                    { 436, "Roberta" },
                    { 437, "Rodzisława" },
                    { 431, "Rebeka" },
                    { 456, "Samanta" },
                    { 457, "Sandra" },
                    { 458, "Sara" },
                    { 477, "Sydney" },
                    { 478, "Strzeżymira" },
                    { 479, "Subisława" },
                    { 480, "Sulima" },
                    { 481, "Sulisława" },
                    { 482, "Sybilla" },
                    { 476, "Stella" },
                    { 483, "Sylwana" },
                    { 485, "Szarlota" },
                    { 486, "Szarlin" },
                    { 487, "Szarlina" },
                    { 488, "Szejma" },
                    { 489, "Szymona" },
                    { 490, "Świetlana" },
                    { 484, "Sylwia" },
                    { 422, "Ramona" },
                    { 475, "Stoisława" },
                    { 473, "Stefania" },
                    { 459, "Sebastiana" },
                    { 460, "Selena" },
                    { 461, "Selma" },
                    { 462, "Serafina" },
                    { 463, "Seweryna" },
                    { 464, "Sędomira" },
                    { 474, "Stela" },
                    { 465, "Sędzisława" },
                    { 467, "Sławina" },
                    { 468, "Sławomira" },
                    { 469, "Sobiesława" },
                    { 470, "Sonia" },
                    { 471, "Stamira" },
                    { 472, "Stanisława" },
                    { 466, "Sława" },
                    { 561, "Żywisław" },
                    { 281, "Ksenia" },
                    { 279, "Krzysztofa" },
                    { 102, "Czesława" },
                    { 101, "Cina" },
                    { 100, "Cinosława" },
                    { 99, "Ciesława" },
                    { 98, "Ciechosława" },
                    { 97, "Chwalisława" },
                    { 96, "Chociemira" },
                    { 95, "Cezaryna" },
                    { 94, "Cezaria" },
                    { 93, "Celina" },
                    { 92, "Celestyna" },
                    { 91, "Cecylia" },
                    { 90, "Brygida" },
                    { 89, "Brunhilda" },
                    { 88, "Bronisława" },
                    { 87, "Bromira" },
                    { 86, "Bożena" },
                    { 72, "Berta" },
                    { 73, "Betina" },
                    { 74, "Bianka" },
                    { 75, "Bibiana" },
                    { 76, "Blanka" },
                    { 77, "Błażena" },
                    { 103, "Dajmira" },
                    { 78, "Bogdana" },
                    { 80, "Boguchwała" },
                    { 81, "Bogumiła" },
                    { 82, "Bogusława" },
                    { 83, "Bojana" },
                    { 84, "Bolesława" },
                    { 85, "Bona" },
                    { 79, "Bogna" },
                    { 71, "Bernadeta" },
                    { 104, "Dagna" },
                    { 106, "Dalia" },
                    { 137, "Elżbieta" },
                    { 136, "Elwira" },
                    { 135, "Eliza" },
                    { 134, "Eleonora" },
                    { 133, "Edyta" },
                    { 132, "Edeltruda" },
                    { 131, "Dżesika" },
                    { 130, "Dżamila" },
                    { 129, "Dżanan" },
                    { 128, "Dyzma" },
                    { 127, "Dorota" },
                    { 126, "Dorosława" },
                    { 125, "Donata" },
                    { 124, "Dominika" },
                    { 123, "Domasława" },
                    { 122, "Dobiesława" },
                    { 121, "Dilara" },
                    { 107, "Dalila" },
                    { 108, "Dalmira" },
                    { 109, "Damroka" },
                    { 110, "Dana" },
                    { 111, "Daniela" },
                    { 112, "Danisława" },
                    { 105, "Dagmara" },
                    { 113, "Danuta" },
                    { 115, "Dargosława" },
                    { 116, "Daria" },
                    { 117, "Dąbrówka" },
                    { 118, "Delfina" },
                    { 119, "Delia" },
                    { 120, "Diana" },
                    { 114, "Dargomira" },
                    { 70, "Bernarda" },
                    { 69, "Berenika" },
                    { 68, "Beniamina" },
                    { 31, "Amira" },
                    { 30, "Amina" },
                    { 29, "Amelia" },
                    { 28, "Amber" },
                    { 27, "Amanda" },
                    { 26, "Amalia" },
                    { 25, "Alojza" },
                    { 24, "Alina" },
                    { 23, "Alida" },
                    { 22, "Alicja" },
                    { 21, "Alfreda" },
                    { 20, "Aleksja" },
                    { 19, "Aleksandra" },
                    { 18, "Aleksa" },
                    { 17, "Aldona" },
                    { 16, "Albina" },
                    { 15, "Albertyna" },
                    { 1, "Ada" },
                    { 2, "Adamina" },
                    { 3, "Adela" },
                    { 4, "Adelajda" },
                    { 5, "Adriana" },
                    { 6, "Adrianna" },
                    { 32, "Ana" },
                    { 7, "Agata" },
                    { 9, "Agrypina" },
                    { 10, "Afra" },
                    { 11, "Aida" },
                    { 12, "Aisza" },
                    { 13, "Ajna" },
                    { 14, "Alberta" },
                    { 8, "Agnieszka" },
                    { 33, "Anastazja" },
                    { 34, "Andrea" },
                    { 35, "Andrzeja" },
                    { 54, "Atena" },
                    { 55, "Augusta" },
                    { 56, "Augustyna" },
                    { 57, "Aurelia" },
                    { 58, "Aurora" },
                    { 59, "Babeta" },
                    { 53, "Astryda" },
                    { 60, "Balbina" },
                    { 62, "Bartłomieja" },
                    { 63, "Beata" },
                    { 64, "Beatrycja" },
                    { 65, "Beatrycze" },
                    { 66, "Beatryksa" },
                    { 67, "Benedykta" },
                    { 61, "Barbara" },
                    { 138, "Elmira" },
                    { 52, "Arnolda" },
                    { 50, "Ariadna" },
                    { 36, "Andżelika" },
                    { 37, "Aneta" },
                    { 38, "Angela" },
                    { 39, "Angelika" },
                    { 40, "Angelina" },
                    { 41, "Aniela" },
                    { 51, "Arleta" },
                    { 42, "Anita" },
                    { 44, "Antonina" },
                    { 45, "Anzelma" },
                    { 46, "Apollona" },
                    { 47, "Apollina" },
                    { 48, "Apolonia" },
                    { 49, "Arabella" },
                    { 43, "Anna" },
                    { 280, "Ksawera" },
                    { 139, "Emanuela" },
                    { 141, "Emina" },
                    { 243, "Józefina" },
                    { 242, "Józefa" },
                    { 241, "Jowita" },
                    { 240, "Jolanta" },
                    { 239, "Joanna" },
                    { 238, "Joachima" },
                    { 237, "Jaśmina" },
                    { 236, "Jasława" },
                    { 235, "Jarosława" },
                    { 234, "Jaromira" },
                    { 233, "Jaromiła" },
                    { 232, "Jarmiła" },
                    { 231, "Janina" },
                    { 230, "Jana" },
                    { 229, "Jago" },
                    { 228, "Jadwiga" },
                    { 227, "Izydora" },
                    { 213, "Ildefonsa" },
                    { 214, "Ilia" },
                    { 215, "Iliana" },
                    { 216, "Ilona" },
                    { 217, "Ilza" },
                    { 218, "Inga" },
                    { 244, "Judyta" },
                    { 219, "Ingeborga" },
                    { 221, "Irena" },
                    { 222, "Iryda" },
                    { 223, "Iwa" },
                    { 224, "Iwona" },
                    { 225, "Izabela" },
                    { 226, "Izolda" },
                    { 220, "Ingryda" },
                    { 212, "Iga" },
                    { 245, "Julia" },
                    { 247, "Julisława" },
                    { 278, "Krystyna" },
                    { 277, "Krystiana" },
                    { 276, "Koryna" },
                    { 275, "Kornelia" },
                    { 274, "Kordula" },
                    { 273, "Konstancja" },
                    { 272, "Klotylda" },
                    { 271, "Kleopatra" },
                    { 270, "Klementyna" },
                    { 269, "Klaudyna" },
                    { 268, "Klaudia" },
                    { 267, "Klarysa" },
                    { 266, "Klara" },
                    { 265, "Kira" },
                    { 264, "Kinga" },
                    { 263, "Kiliana" },
                    { 262, "Kiara" },
                    { 248, "Julita" },
                    { 249, "Justyna" },
                    { 250, "Juta" },
                    { 251, "Kaja" },
                    { 252, "Kalina" },
                    { 253, "Kamila" },
                    { 246, "Julianna" },
                    { 254, "Karima" },
                    { 256, "Karola" },
                    { 257, "Karolina" },
                    { 258, "Karyna" },
                    { 259, "Katarzyna" },
                    { 260, "Kasandra" },
                    { 261, "Kazimiera" },
                    { 255, "Karina" },
                    { 211, "Idzisława" },
                    { 210, "Idalia" },
                    { 209, "Idzia" },
                    { 172, "Gerarda" },
                    { 171, "Genowefa" },
                    { 170, "Gaja" },
                    { 169, "Gabriela" },
                    { 168, "Fryderyka" },
                    { 167, "Franciszka" },
                    { 166, "Floriana" },
                    { 165, "Florentyna" },
                    { 164, "Flora" },
                    { 163, "Filipina" },
                    { 162, "Filipa" },
                    { 161, "Ferdynanda" },
                    { 160, "Feliksa" },
                    { 159, "Felicyta" },
                    { 158, "Felicjana" },
                    { 157, "Felicja" },
                    { 156, "Faustyna" },
                    { 142, "Emma" },
                    { 143, "Ernesta" },
                    { 144, "Ernestyna" },
                    { 145, "Eryka" },
                    { 146, "Estera" },
                    { 147, "Eugenia" },
                    { 173, "Gertruda" },
                    { 148, "Ewa" },
                    { 150, "Fabia" },
                    { 151, "Fabiana" },
                    { 152, "Fabiola" },
                    { 153, "Farida" },
                    { 154, "Fatima" },
                    { 155, "Fatma" },
                    { 149, "Ewelina" },
                    { 174, "Gizela" },
                    { 175, "Gloria" },
                    { 176, "Gniewomira" },
                    { 195, "Hermana" },
                    { 196, "Hermenegilda" },
                    { 197, "Hermina" },
                    { 198, "Hestia" },
                    { 199, "Hiacynta" },
                    { 200, "Hilaria" },
                    { 194, "Herma" },
                    { 201, "Hildegarda" },
                    { 203, "Honorata" },
                    { 204, "Hortensja" },
                    { 205, "Huberta" },
                    { 206, "Husaria" },
                    { 207, "Ida" },
                    { 208, "Idosława" },
                    { 202, "Hipolit" },
                    { 140, "Emilia" },
                    { 193, "Henryka" },
                    { 191, "Helga" },
                    { 177, "Gracja" },
                    { 178, "Gracjana" },
                    { 179, "Grażyna" },
                    { 180, "Greta" },
                    { 181, "Gryzelda" },
                    { 182, "Grzymisława" },
                    { 192, "Henrieta" },
                    { 183, "Gustawa" },
                    { 185, "Hadriana" },
                    { 186, "Halina" },
                    { 187, "Halszka" },
                    { 188, "Hanna" },
                    { 189, "Hedwiga" },
                    { 190, "Helena" },
                    { 184, "Gwidona" }
                });

            migrationBuilder.InsertData(
                table: "NamesOfProperties",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "NameOf", "PropertyId" },
                values: new object[,]
                {
                    { 11, "Czarny", 1 },
                    { 10, "Fioletowy", 1 },
                    { 8, "Zielony", 1 },
                    { 7, "Szary", 1 },
                    { 6, "Żółty", 1 },
                    { 9, "Niebieski", 1 },
                    { 4, "Pomarańczowy", 1 },
                    { 3, "Czerwony", 1 },
                    { 2, "Różowy", 1 },
                    { 1, "Biały", 1 },
                    { 5, "Brązowy", 1 }
                });

            migrationBuilder.InsertData(
                table: "Marks",
                columns: new[] { "Id", "NameOf", "PropertyId" },
                values: new object[,]
                {
                    { 1, "Zara", 1 },
                    { 2, "Hnm", 1 },
                    { 3, "Mohito", 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "NameOf", "PropertyId" },
                values: new object[,]
                {
                    { 9, "37", 1 },
                    { 13, "41", 1 },
                    { 12, "40", 1 },
                    { 11, "39", 1 },
                    { 10, "38", 1 },
                    { 8, "36", 1 },
                    { 4, "m", 1 },
                    { 6, "xl", 1 },
                    { 5, "l", 1 },
                    { 3, "s", 1 },
                    { 2, "xs", 1 },
                    { 1, "xxs", 1 },
                    { 7, "xxl", 1 }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "NameOf", "PropertyId" },
                values: new object[,]
                {
                    { 8, "Bluzka", 1 },
                    { 1, "Biżuteria", 1 },
                    { 2, "Dodatki", 1 },
                    { 3, "Torebka", 1 },
                    { 4, "Spodnie", 1 },
                    { 5, "Sukienka", 1 },
                    { 6, "Spódnica", 1 },
                    { 7, "Kurtka", 1 },
                    { 9, "Buty", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_Agreement_Id",
                table: "Clothes",
                column: "Agreement_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_AnnualReportId",
                table: "Clothes",
                column: "AnnualReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_DailyReportId",
                table: "Clothes",
                column: "DailyReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_MonthlyReportId",
                table: "Clothes",
                column: "MonthlyReportId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_PropertyId",
                table: "Colors",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_PropertyId",
                table: "Marks",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_PropertyId",
                table: "Sizes",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_PropertyId",
                table: "Types",
                column: "PropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Clothes");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "LastnamesLists");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "NamesLists");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Agreements");

            migrationBuilder.DropTable(
                name: "AnnualReports");

            migrationBuilder.DropTable(
                name: "DailyReports");

            migrationBuilder.DropTable(
                name: "MonthlyReports");

            migrationBuilder.DropTable(
                name: "NamesOfProperties");
        }
    }
}
