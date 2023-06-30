using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class coffee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coffee",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coffee", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coffee_photo",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    coffee_id = table.Column<long>(type: "bigint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    file_url = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coffee_photo", x => x.id);
                    table.ForeignKey(
                        name: "fk_coffee_photo_coffee_coffee_id",
                        column: x => x.coffee_id,
                        principalTable: "coffee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "coffee_translation",
                columns: table => new
                {
                    language_id = table.Column<int>(type: "integer", nullable: false),
                    coffee_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    description = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    id = table.Column<long>(type: "bigint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coffee_translation", x => new { x.language_id, x.coffee_id });
                    table.ForeignKey(
                        name: "fk_coffee_translation_coffee_coffee_id",
                        column: x => x.coffee_id,
                        principalTable: "coffee",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_coffee_created_date",
                table: "coffee",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_is_deleted",
                table: "coffee",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_photo_coffee_id",
                table: "coffee_photo",
                column: "coffee_id");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_photo_created_date",
                table: "coffee_photo",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_photo_is_deleted",
                table: "coffee_photo",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_translation_coffee_id",
                table: "coffee_translation",
                column: "coffee_id");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_translation_created_date",
                table: "coffee_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_translation_is_deleted",
                table: "coffee_translation",
                column: "is_deleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coffee_photo");

            migrationBuilder.DropTable(
                name: "coffee_translation");

            migrationBuilder.DropTable(
                name: "coffee");
        }
    }
}
