using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class coffee_type_index : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "coffee_type_id",
                table: "coffee",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_coffee_coffee_type_id",
                table: "coffee",
                column: "coffee_type_id");

            migrationBuilder.AddForeignKey(
                name: "fk_coffee_coffee_types_coffee_type_id",
                table: "coffee",
                column: "coffee_type_id",
                principalTable: "coffee_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_coffee_coffee_types_coffee_type_id",
                table: "coffee");

            migrationBuilder.DropIndex(
                name: "ix_coffee_coffee_type_id",
                table: "coffee");

            migrationBuilder.DropColumn(
                name: "coffee_type_id",
                table: "coffee");
        }
    }
}
