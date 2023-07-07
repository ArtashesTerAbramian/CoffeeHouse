using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeHouse.DAL.Migrations
{
    public partial class province_seeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "provinces",
                columns: new[] { "id", "created_date", "is_deleted", "modify_date" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 2L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 3L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 4L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 5L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 6L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 7L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 8L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 9L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 10L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) },
                    { 11L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc) }
                });

            migrationBuilder.InsertData(
                table: "province_translation",
                columns: new[] { "id", "created_date", "is_deleted", "language_id", "modify_date", "name", "province_id" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Aragatsotn region", 1L },
                    { 2L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Арагацотнская область", 1L },
                    { 3L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արագածոտնի մարզ", 1L },
                    { 4L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ararat region", 2L },
                    { 5L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Араратская область", 2L },
                    { 6L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արարատյան մարզ", 2L },
                    { 7L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Armavir region", 3L },
                    { 8L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Армавирская область", 3L },
                    { 9L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Արմավիրի մարզ", 3L },
                    { 10L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Yerevan", 4L },
                    { 11L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ереван", 4L },
                    { 12L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Երեվան", 4L },
                    { 13L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vayots Dzor region", 5L },
                    { 14L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Вайоцдзорская бласть", 5L },
                    { 15L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Վայոց Ձորի մարզ", 5L },
                    { 16L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gegharkunik region", 6L },
                    { 17L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Гехаркуникская область", 6L },
                    { 18L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Գեղարքունիքի մարզ", 6L },
                    { 19L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kotayk region", 7L },
                    { 20L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Котайкская область", 7L },
                    { 21L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Կոտայքի մարզ", 7L },
                    { 22L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Lori region", 8L },
                    { 23L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Лорийская область", 8L },
                    { 24L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Լոռու մարզ", 8L },
                    { 25L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Shirak region", 9L },
                    { 26L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ширакская область", 9L },
                    { 27L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Շիրակի մարզ", 9L },
                    { 28L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tavush region", 10L },
                    { 29L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Тавушская область", 10L },
                    { 30L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Տավուշի մարզ", 10L },
                    { 31L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Syunik region", 11L },
                    { 32L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 2, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сюникская область", 11L },
                    { 33L, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), false, 3, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Սյունիքի մարզ", 11L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "province_translation",
                keyColumn: "id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "provinces",
                keyColumn: "id",
                keyValue: 11L);
        }
    }
}
