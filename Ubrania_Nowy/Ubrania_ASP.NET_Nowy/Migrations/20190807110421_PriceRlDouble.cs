using Microsoft.EntityFrameworkCore.Migrations;

namespace Ubrania_ASP.NET_Nowy.Migrations
{
    public partial class PriceRlDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price_RL",
                table: "Clothes",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price_RL",
                table: "Clothes",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
