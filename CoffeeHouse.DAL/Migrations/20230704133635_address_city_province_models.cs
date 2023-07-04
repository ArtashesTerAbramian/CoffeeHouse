using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class address_city_province_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "provinces",
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
                    table.PrimaryKey("pk_provinces", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    province_id = table.Column<long>(type: "bigint", nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_city", x => x.id);
                    table.ForeignKey(
                        name: "fk_city_provinces_province_id",
                        column: x => x.province_id,
                        principalTable: "provinces",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "province_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    province_id = table.Column<long>(type: "bigint", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_province_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_province_translation_provinces_province_id",
                        column: x => x.province_id,
                        principalTable: "provinces",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    city_id = table.Column<long>(type: "bigint", nullable: false),
                    postal_code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_address", x => x.id);
                    table.ForeignKey(
                        name: "fk_address_cities_city_id",
                        column: x => x.city_id,
                        principalTable: "city",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "city_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    city_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_city_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_city_translation_city_city_id",
                        column: x => x.city_id,
                        principalTable: "city",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "address_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    address_id = table.Column<long>(type: "bigint", nullable: false),
                    street = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    state = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_address_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_address_translation_address_address_id",
                        column: x => x.address_id,
                        principalTable: "address",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_address_city_id",
                table: "address",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "ix_address_created_date",
                table: "address",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_address_is_deleted",
                table: "address",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_address_translation_address_id",
                table: "address_translation",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "ix_address_translation_created_date",
                table: "address_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_address_translation_is_deleted",
                table: "address_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_city_created_date",
                table: "city",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_city_is_deleted",
                table: "city",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_city_province_id",
                table: "city",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "ix_city_translation_city_id",
                table: "city_translation",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "ix_city_translation_created_date",
                table: "city_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_city_translation_is_deleted",
                table: "city_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_province_translation_created_date",
                table: "province_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_province_translation_is_deleted",
                table: "province_translation",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_province_translation_province_id",
                table: "province_translation",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "ix_provinces_created_date",
                table: "provinces",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_provinces_is_deleted",
                table: "provinces",
                column: "is_deleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "address_translation");

            migrationBuilder.DropTable(
                name: "city_translation");

            migrationBuilder.DropTable(
                name: "province_translation");

            migrationBuilder.DropTable(
                name: "address");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "provinces");
        }
    }
}
