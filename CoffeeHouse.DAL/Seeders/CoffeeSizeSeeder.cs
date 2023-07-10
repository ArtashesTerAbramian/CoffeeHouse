using CoffeeHouse.DAL.Enums;
using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.DAL.Seeders;

public class CoffeeSizeSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        var englishValues = Enum.GetValues(typeof(CoffeeSizeEnum));
        var russianValues = new[] { "Маленький", "Средний", "Большой" };
        var armenianValues = new[] { "Փոքր", "Միջին", "Մեծ" };
        
        int translationId = 0;

        for (int i = 0; i < englishValues.Length; i++)
        {
            modelBuilder.Entity<CoffeeSize>().HasData(new CoffeeSize
            {
                Id = i + 1,
                SizeEnum = (CoffeeSizeEnum)englishValues.GetValue(i), // Replace with the appropriate province ID for each city
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false,
            });

            modelBuilder.Entity<CoffeeSizeTranslation>().HasData(new CoffeeSizeTranslation
            {
                Id = ++translationId,
                CoffeeSizeId = i + 1,
                LanguageId = 1,
                Size = englishValues.GetValue(i).ToString(),
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false
            });

            modelBuilder.Entity<CoffeeSizeTranslation>().HasData(new CoffeeSizeTranslation
            {
                Id = ++translationId,
                CoffeeSizeId = i + 1,
                LanguageId = 2,
                Size = russianValues[i],
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false
            });
            modelBuilder.Entity<CoffeeSizeTranslation>().HasData(new CoffeeSizeTranslation
            {
                Id = ++translationId,
                CoffeeSizeId = i + 1,
                LanguageId = 3,
                Size = armenianValues[i],
                CreatedDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                ModifyDate = new DateTime(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
                IsDeleted = false
            });
        }
    }
}
