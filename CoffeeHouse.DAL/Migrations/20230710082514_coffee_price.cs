using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class coffee_price : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "coffee",
                type: "numeric(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "coffee");
        }
    }
}
