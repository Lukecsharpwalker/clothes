using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class proteptiesWithValuesAndIneach2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameOf",
                value: "Czerwony");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameOf",
                value: "Torebka");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "NameOf",
                value: "Sukienka");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6,
                column: "NameOf",
                value: "Spódnica");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7,
                column: "NameOf",
                value: "Kurtka");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 8,
                column: "NameOf",
                value: "Bluzka");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameOf",
                value: "Czerwny");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3,
                column: "NameOf",
                value: "Torebki");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5,
                column: "NameOf",
                value: "Sukienki");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6,
                column: "NameOf",
                value: "Spódnice");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7,
                column: "NameOf",
                value: "Kurtki");

            migrationBuilder.UpdateData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 8,
                column: "NameOf",
                value: "Bluzki");
        }
    }
}
