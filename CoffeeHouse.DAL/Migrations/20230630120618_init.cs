﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coffee_type",
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
                    table.PrimaryKey("pk_coffee_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "coffee_type_translation",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    coffee_type_id = table.Column<long>(type: "bigint", nullable: false),
                    name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    created_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    modify_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    is_deleted = table.Column<bool>(type: "boolean", nullable: false),
                    language_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_coffee_type_translation", x => x.id);
                    table.ForeignKey(
                        name: "fk_coffee_type_translation_coffee_type_coffee_type_id",
                        column: x => x.coffee_type_id,
                        principalTable: "coffee_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "coffee_type",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "coffee_type_translation",
                columns: new[] { "id", "coffee_type_id", "created_date", "is_deleted", "language_id", "modify_date", "name" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Affogato" },
                    { 2L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Аффогато" },
                    { 3L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Աֆֆոքատո" },
                    { 4L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Americano" },
                    { 5L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Американо" },
                    { 6L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ամերիկանո" },
                    { 7L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Latte" },
                    { 8L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Латте" },
                    { 9L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Լատե" },
                    { 10L, 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Cappuccino" },
                    { 11L, 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Капучино" },
                    { 12L, 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կապուչինո" },
                    { 13L, 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mocha" },
                    { 14L, 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Моча" },
                    { 15L, 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մոչա" },
                    { 16L, 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Macchiato" },
                    { 17L, 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Мачиато" },
                    { 18L, 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մաչիատո" },
                    { 19L, 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Espresso" },
                    { 20L, 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Еспресо" },
                    { 21L, 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Եսպրեսօ" },
                    { 22L, 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Decaf" },
                    { 23L, 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Декаф" },
                    { 24L, 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Դեկաֆ" },
                    { 25L, 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Frappuccino" },
                    { 26L, 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Фрапучино" },
                    { 27L, 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ֆրապուփչինո" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_coffee_type_created_date",
                table: "coffee_type",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_type_is_deleted",
                table: "coffee_type",
                column: "is_deleted");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_type_translation_coffee_type_id_language_id",
                table: "coffee_type_translation",
                columns: new[] { "coffee_type_id", "language_id" });

            migrationBuilder.CreateIndex(
                name: "ix_coffee_type_translation_created_date",
                table: "coffee_type_translation",
                column: "created_date");

            migrationBuilder.CreateIndex(
                name: "ix_coffee_type_translation_is_deleted",
                table: "coffee_type_translation",
                column: "is_deleted");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coffee_type_translation");

            migrationBuilder.DropTable(
                name: "coffee_type");
        }
    }
}
