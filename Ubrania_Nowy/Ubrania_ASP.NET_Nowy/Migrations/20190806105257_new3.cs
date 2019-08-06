using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NamesOfProperties_Clothes_ClothId",
                table: "NamesOfProperties");

            migrationBuilder.DropIndex(
                name: "IX_NamesOfProperties_ClothId",
                table: "NamesOfProperties");

            migrationBuilder.DropColumn(
                name: "ClothId",
                table: "NamesOfProperties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClothId",
                table: "NamesOfProperties",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NamesOfProperties_ClothId",
                table: "NamesOfProperties",
                column: "ClothId");

            migrationBuilder.AddForeignKey(
                name: "FK_NamesOfProperties_Clothes_ClothId",
                table: "NamesOfProperties",
                column: "ClothId",
                principalTable: "Clothes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
