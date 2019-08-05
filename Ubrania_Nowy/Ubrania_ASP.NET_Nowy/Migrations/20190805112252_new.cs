using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Colour",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Clothes");

            migrationBuilder.AddColumn<int>(
                name: "ColourId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarkId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Clothes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_ColourId",
                table: "Clothes",
                column: "ColourId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_MarkId",
                table: "Clothes",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_SizeId",
                table: "Clothes",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clothes_TypeId",
                table: "Clothes",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Colors_ColourId",
                table: "Clothes",
                column: "ColourId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Marks_MarkId",
                table: "Clothes",
                column: "MarkId",
                principalTable: "Marks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Sizes_SizeId",
                table: "Clothes",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clothes_Types_TypeId",
                table: "Clothes",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Colors_ColourId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Marks_MarkId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Sizes_SizeId",
                table: "Clothes");

            migrationBuilder.DropForeignKey(
                name: "FK_Clothes_Types_TypeId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_ColourId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_MarkId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_SizeId",
                table: "Clothes");

            migrationBuilder.DropIndex(
                name: "IX_Clothes_TypeId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "ColourId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "MarkId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Clothes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Clothes");

            migrationBuilder.AddColumn<string>(
                name: "Colour",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mark",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Clothes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Clothes",
                nullable: true);
        }
    }
}
