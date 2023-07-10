using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class coffee_size : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "ix_coffee_coffee_type_id",
                table: "coffee");

            migrationBuilder.AddColumn<long>(
                name: "coffee_size_id",
                table: "coffee",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "coffee_size",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    size_enum = table.Column<int>(type: "integer", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coffee_size", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coffee_size_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    coffee_size_id = table.Column<long>(type: "bigint", nullable: false),
                    size = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coffee_size_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_coffee_size_translation_coffee_size_coffee_size_id",
                        column: x => x.coffee_size_id,
                        principalTable: "coffee_size",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "coffee_size",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date", "size_enum" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 3 }
                });

            migrationBuilder.InsertData(
                table: "coffee_size_translation",
                columns: new[] { "id", "coffee_size_id", "created_date", "is_deleted", "language_id", "modify_date", "size" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Small" },
                    { 2L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Маленький" },
                    { 3L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Փոքր" },
                    { 4L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Medium" },
                    { 5L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Средний" },
                    { 6L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Միջին" },
                    { 7L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Large" },
                    { 8L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Большой" },
                    { 9L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մեծ" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_coffee_coffee_size_id",
                table: "coffee",
                column: "coffee_size_id");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_coffee_type_id_coffee_size_id",
                table: "coffee",
                columns: new[] { "coffee_type_id", "coffee_size_id" });

            migrationBuilder.CreateIndex(
                name: "ix_coffee_size_created_date",
                table: "coffee_size",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_size_is_deleted",
                table: "coffee_size",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_size_translation_coffee_size_id",
                table: "coffee_size_translation",
                column: "coffee_size_id");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_size_translation_created_date",
                table: "coffee_size_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_size_translation_is_deleted",
                table: "coffee_size_translation",
                column: "is_deleted");

            migrationBuilder.AddForeignKey(
                name: "fk_coffee_coffee_size_coffee_size_id",
                table: "coffee",
                column: "coffee_size_id",
                principalTable: "coffee_size",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_coffee_coffee_size_coffee_size_id",
                table: "coffee");

            migrationBuilder.DropTable(
                name: "coffee_size_translation");

            migrationBuilder.DropTable(
                name: "coffee_size");

            migrationBuilder.DropIndex(
                name: "ix_coffee_coffee_size_id",
                table: "coffee");

            migrationBuilder.DropIndex(
                name: "ix_coffee_coffee_type_id_coffee_size_id",
                table: "coffee");

            migrationBuilder.DropColumn(
                name: "coffee_size_id",
                table: "coffee");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_coffee_type_id",
                table: "coffee",
                column: "coffee_type_id");
        }
    }
}
