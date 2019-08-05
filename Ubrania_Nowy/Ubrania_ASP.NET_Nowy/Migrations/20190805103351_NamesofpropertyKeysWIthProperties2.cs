using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class NamesofpropertyKeysWIthProperties2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Marks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Types",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NamesOfProperties",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
