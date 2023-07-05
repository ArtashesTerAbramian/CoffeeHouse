using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.DAL.Seeders;

internal static class ProvinceSeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        #region Aragatsotn

        modelBuilder.Entity<Province>().HasData(new Province()
        {
            Id = 1,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        modelBuilder.Entity<ProvinceTranslation>().HasData(new ProvinceTranslation()
        {
            Id = 1,
            LanguageId = 1,
            ProvinceId = 1,
            Name = "Aragatsotn",
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        modelBuilder.Entity<ProvinceTranslation>().HasData(new ProvinceTranslation()
        {
            Id = 2,
            LanguageId = 2,
            ProvinceId = 1,
            Name = "Арагацотнская",
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        modelBuilder.Entity<ProvinceTranslation>().HasData(new ProvinceTranslation()
        {
            Id = 3,
            LanguageId = 3,
            ProvinceId = 1,
            Name = "Արագածոտնի",
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Ararat

        modelBuilder.Entity<Province>().HasData(new Province()
        {
            Id = 2,
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        modelBuilder.Entity<ProvinceTranslation>().HasData(new ProvinceTranslation()
        {
            Id = 4,
            LanguageId = 1,
            ProvinceId = 2,
            Name = "Ararat",
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        modelBuilder.Entity<ProvinceTranslation>().HasData(new ProvinceTranslation()
        {
            Id = 5,
            LanguageId = 2,
            ProvinceId = 2,
            Name = "Араратская",
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        modelBuilder.Entity<ProvinceTranslation>().HasData(new ProvinceTranslation()
        {
            Id = 6,
            LanguageId = 3,
            ProvinceId = 2,
            Name = "Արարատյան",
            CreatedDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion
    }
}
