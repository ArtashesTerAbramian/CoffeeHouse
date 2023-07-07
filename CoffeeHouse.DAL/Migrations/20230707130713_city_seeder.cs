using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class city_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "city",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date", "province_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 10L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 11L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 12L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 13L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 14L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 15L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 16L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 17L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 18L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 19L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 20L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 21L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 22L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 23L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 24L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 25L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 26L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 27L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 28L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 29L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 30L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 31L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 32L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 33L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 34L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 35L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 36L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 37L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 38L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 39L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 40L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 41L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 42L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 43L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 44L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 45L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 46L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 47L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 48L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 49L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 50L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 51L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 52L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 53L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 54L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 55L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 56L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 57L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 58L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 59L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 60L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 61L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 62L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 63L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 64L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 65L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 66L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 67L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 68L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L },
                    { 69L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), 4L }
                });

            migrationBuilder.InsertData(
                table: "city_translation",
                columns: new[] { "id", "city_id", "created_date", "is_deleted", "language_id", "modify_date", "name" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Yerevan" },
                    { 2L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ереван" },
                    { 3L, 1L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Երևան" },
                    { 4L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Aparan" },
                    { 5L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Апаран" },
                    { 6L, 2L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ապարան" },
                    { 7L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Artashat" },
                    { 8L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Арташат" },
                    { 9L, 3L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արթաշատ" },
                    { 10L, 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vanaadzor" },
                    { 11L, 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ванадзор" },
                    { 12L, 4L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Վանաձոր" },
                    { 13L, 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gyumri" },
                    { 14L, 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Гюмри" },
                    { 15L, 5L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Գյումրի" },
                    { 16L, 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Goris" },
                    { 17L, 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Горис" },
                    { 18L, 6L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Գորիս" },
                    { 19L, 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hrazdan" },
                    { 20L, 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Граздан" },
                    { 21L, 7L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հրազդան" },
                    { 22L, 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kapan" },
                    { 23L, 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Капан" },
                    { 24L, 8L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Քանաքեռավան" },
                    { 25L, 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Masis" },
                    { 26L, 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Масис" },
                    { 27L, 9L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մարալիկ" },
                    { 28L, 10L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sebastia" },
                    { 29L, 10L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Себастия" },
                    { 30L, 10L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Սեբաստիա" },
                    { 31L, 11L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stepanavan" },
                    { 32L, 11L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Степанаван" },
                    { 33L, 11L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ստեփանավան" },
                    { 34L, 12L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Abovyan" },
                    { 35L, 12L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Абовян" },
                    { 36L, 12L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Աբովյան" },
                    { 37L, 13L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Agharak" },
                    { 38L, 13L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Агарак" },
                    { 39L, 13L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ագարակ" },
                    { 40L, 14L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Alaverdi" },
                    { 41L, 14L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Алаверди" },
                    { 42L, 14L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ալավերդի" },
                    { 43L, 15L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ashtarak" },
                    { 44L, 15L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Аштарак" },
                    { 45L, 15L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Աշտարակ" },
                    { 46L, 16L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Aparan" },
                    { 47L, 16L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Апаран" },
                    { 48L, 16L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ապարան" },
                    { 49L, 17L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ararat" },
                    { 50L, 17L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Арарат" },
                    { 51L, 17L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արարատ" },
                    { 52L, 18L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Arats" },
                    { 53L, 18L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Аратс" },
                    { 54L, 18L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արարած" },
                    { 55L, 19L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Armavir" },
                    { 56L, 19L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Армавир" },
                    { 57L, 19L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արմավիր" },
                    { 58L, 20L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Arevmat" },
                    { 59L, 20L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Аревмат" },
                    { 60L, 20L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արևամուտ" },
                    { 61L, 21L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gavar" },
                    { 62L, 21L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Гавар" },
                    { 63L, 21L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Գավառ" },
                    { 64L, 22L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gyumri" },
                    { 65L, 22L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Гюмри" },
                    { 66L, 22L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Գյումրի" },
                    { 67L, 23L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Dilijan" },
                    { 68L, 23L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Дилижан" },
                    { 69L, 23L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Դիլիջան" },
                    { 70L, 24L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Yeghegnadzor" },
                    { 71L, 24L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Егегнадзор" },
                    { 72L, 24L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Եղեգնաձոր" },
                    { 73L, 25L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Yegvard" },
                    { 74L, 25L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Егвард" },
                    { 75L, 25L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Եղվարդ" },
                    { 76L, 26L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Yeghegnik" },
                    { 77L, 26L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Егегник" },
                    { 78L, 26L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Եգեղեցիկ" },
                    { 79L, 27L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Yeveran" },
                    { 80L, 27L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Еверан" },
                    { 81L, 27L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Եվերեան" },
                    { 82L, 28L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ejmiatsin" },
                    { 83L, 28L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Эчмиадзин" },
                    { 84L, 28L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Էջմիածին" },
                    { 85L, 29L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Talin" },
                    { 86L, 29L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Талин" },
                    { 87L, 29L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Թալին" },
                    { 88L, 30L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tumanyan" },
                    { 89L, 30L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Туманян" },
                    { 90L, 30L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Թումանյան" },
                    { 91L, 31L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tijvat" },
                    { 92L, 31L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Тийват" },
                    { 93L, 31L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Թիջուատ" },
                    { 94L, 32L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Zhambarak" },
                    { 95L, 32L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Жамбарак" },
                    { 96L, 32L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ժամբարակ" },
                    { 97L, 33L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ijevan" },
                    { 98L, 33L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Иджеван" },
                    { 99L, 33L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Իջևան" },
                    { 100L, 34L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lernamut" },
                    { 101L, 34L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Лернамут" },
                    { 102L, 34L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Լեռնամուտ" },
                    { 103L, 35L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lori" },
                    { 104L, 35L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Лори" },
                    { 105L, 35L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Լոռի" },
                    { 106L, 36L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Khanakerd" },
                    { 107L, 36L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ханакерт" },
                    { 108L, 36L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Խանաքեռավան" },
                    { 109L, 37L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tsaghkadzor" },
                    { 110L, 37L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Цахкадзор" },
                    { 111L, 37L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ծաղկաձոր" },
                    { 112L, 38L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kapan" },
                    { 113L, 38L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Капан" },
                    { 114L, 38L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կապան" },
                    { 115L, 39L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sisian" },
                    { 116L, 39L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сисиан" },
                    { 117L, 39L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կասախաղ" },
                    { 118L, 40L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kanachar" },
                    { 119L, 40L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Каначар" },
                    { 120L, 40L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կանանցառ" },
                    { 121L, 41L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kapanavan" },
                    { 122L, 41L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Капанаван" },
                    { 123L, 41L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կապանավան" },
                    { 124L, 42L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kotayk" },
                    { 125L, 42L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Котайк" },
                    { 126L, 42L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կոտայք" },
                    { 127L, 43L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hrazdan" },
                    { 128L, 43L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Граздан" },
                    { 129L, 43L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հրազդան" },
                    { 130L, 44L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Hrayravan" },
                    { 131L, 44L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Грайраван" },
                    { 132L, 44L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Հարավային Մարտունի" },
                    { 133L, 45L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Jamburak" },
                    { 134L, 45L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Джамбурак" },
                    { 135L, 45L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ճամբարակ" },
                    { 136L, 46L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Masis" },
                    { 137L, 46L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Масис" },
                    { 138L, 46L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մասիս" },
                    { 139L, 47L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Maralik" },
                    { 140L, 47L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Маралик" },
                    { 141L, 47L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մարալիկ" },
                    { 142L, 48L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Martakert" },
                    { 143L, 48L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Мартакерт" },
                    { 144L, 48L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մարտակերտ" },
                    { 145L, 49L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Martuni" },
                    { 146L, 49L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Мартуни" },
                    { 147L, 49L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մարտունի" },
                    { 148L, 50L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Meghri" },
                    { 149L, 50L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Мегри" },
                    { 150L, 50L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մեծամոր" },
                    { 151L, 51L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "United Armenia" },
                    { 152L, 51L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Объединенная Армения" },
                    { 153L, 51L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Միացյալ Հայաստան" },
                    { 154L, 52L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Moscow" },
                    { 155L, 52L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Москва" },
                    { 156L, 52L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Մոսկվա" },
                    { 157L, 53L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "November" },
                    { 158L, 53L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ноябрь" },
                    { 159L, 53L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Նոյեմբերյան" },
                    { 160L, 54L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "New Jdeidah" },
                    { 161L, 54L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Новый Джейда" },
                    { 162L, 54L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Նոր Հաճըն" },
                    { 163L, 55L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Shahumyan" },
                    { 164L, 55L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Шахумян" },
                    { 165L, 55L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Շահումյան" },
                    { 166L, 56L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Shavarshen" },
                    { 167L, 56L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Шаваршен" },
                    { 168L, 56L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Շավարշեն" },
                    { 169L, 57L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Shirak" },
                    { 170L, 57L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ширак" },
                    { 171L, 57L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Շիրակ" },
                    { 172L, 58L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Shushi" },
                    { 173L, 58L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Шуши" },
                    { 174L, 58L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Շուշի" },
                    { 175L, 59L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sutis" },
                    { 176L, 59L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сутис" },
                    { 177L, 59L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Շուտիս" },
                    { 178L, 60L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sisian" },
                    { 179L, 60L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сисиан" },
                    { 180L, 60L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Սիսիան" },
                    { 181L, 61L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Syunik" },
                    { 182L, 61L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сюник" },
                    { 183L, 61L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Սյունիք" },
                    { 184L, 62L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stepanavan" },
                    { 185L, 62L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Степанаван" },
                    { 186L, 62L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ստեփանավան" },
                    { 187L, 63L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stepanakert" },
                    { 188L, 63L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Степанакерт" },
                    { 189L, 63L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ստեփանակերտ" },
                    { 190L, 64L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Stepanavan" },
                    { 191L, 64L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Степанаван" },
                    { 192L, 64L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ստեփանավունի" },
                    { 193L, 65L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Sevan" },
                    { 194L, 65L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Севан" },
                    { 195L, 65L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Սևան" },
                    { 196L, 66L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tashir" },
                    { 197L, 66L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ташир" },
                    { 198L, 66L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Տաշիր" },
                    { 199L, 67L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tavush" },
                    { 200L, 67L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Тавуш" },
                    { 201L, 67L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Տավուշ" },
                    { 202L, 68L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kasakh" },
                    { 203L, 68L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Касах" },
                    { 204L, 68L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Քասախ" },
                    { 205L, 69L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kaghakanysh" },
                    { 206L, 69L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Кагаканиш" },
                    { 207L, 69L, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Քաղաքանիշ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "city_translation",
                keyColumn: "id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "city",
                keyColumn: "id",
                keyValue: 69L);
        }
    }
}
