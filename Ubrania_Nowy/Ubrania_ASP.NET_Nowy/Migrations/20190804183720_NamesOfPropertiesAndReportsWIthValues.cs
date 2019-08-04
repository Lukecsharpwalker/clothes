using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class NamesOfPropertiesAndReportsWIthValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnnualReportId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DailyReportId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MonthlyReportId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AnnualReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Balance = table.Column<int>(nullable: false),
                    Year = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnualReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DailyReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Balance = table.Column<int>(nullable: false),
                    Day = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthlyReports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Balance = table.Column<int>(nullable: false),
                    Month = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyReports", x => x.Id);
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
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOf = table.Column<string>(nullable: true),
                    NamesOfPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_NamesOfProperties_NamesOfPropertyId",
                        column: x => x.NamesOfPropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOf = table.Column<string>(nullable: true),
                    NamesOfPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_NamesOfProperties_NamesOfPropertyId",
                        column: x => x.NamesOfPropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOf = table.Column<string>(nullable: true),
                    NamesOfPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_NamesOfProperties_NamesOfPropertyId",
                        column: x => x.NamesOfPropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOf = table.Column<string>(nullable: true),
                    NamesOfPropertyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Types_NamesOfProperties_NamesOfPropertyId",
                        column: x => x.NamesOfPropertyId,
                        principalTable: "NamesOfProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_Colors_NamesOfPropertyId",
                table: "Colors",
                column: "NamesOfPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Marks_NamesOfPropertyId",
                table: "Marks",
                column: "NamesOfPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_NamesOfPropertyId",
                table: "Sizes",
                column: "NamesOfPropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Types_NamesOfPropertyId",
                table: "Types",
                column: "NamesOfPropertyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_AnnualReports_AnnualReportId",
                table: "Clothes",
                column: "AnnualReportId",
                principalTable: "AnnualReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_DailyReports_DailyReportId",
                table: "Clothes",
                column: "DailyReportId",
                principalTable: "DailyReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_MonthlyReports_MonthlyReportId",
                table: "Clothes",
                column: "MonthlyReportId",
                principalTable: "MonthlyReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_AnnualReports_AnnualReportId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_DailyReports_DailyReportId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_MonthlyReports_MonthlyReportId",
                table: "Clothes");

            migrationBuilder.DropTable(
                name: "AnnualReports");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "DailyReports");

            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "MonthlyReports");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "NamesOfProperties");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_AnnualReportId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_DailyReportId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_MonthlyReportId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "AnnualReportId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "DailyReportId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "MonthlyReportId",
                table: "Clothes");
        }
    }
}
