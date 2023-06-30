using CoffeeHouse.DAL.Enums;
using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.DAL.Seeders;

public class CoffeeCategorySeeder
{
    public static void SeedData(ModelBuilder modelBuilder)
    {
        #region Affogato

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Affogato,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Affogato,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 1,
            CoffeeCategoryId = 1,
            LanguageId = 1,
            Name = "Affogato",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 2,
            CoffeeCategoryId = 1,
            LanguageId = 2,
            Name = "Аффогато",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 3,
            CoffeeCategoryId = 1,
            LanguageId = 3,
            Name = "Աֆֆոքատո",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Americano

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Americano,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Americano,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 4,
            CoffeeCategoryId = 2,
            LanguageId = 1,
            Name = "Americano",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 5,
            CoffeeCategoryId = 2,
            LanguageId = 2,
            Name = "Американо",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 6,
            CoffeeCategoryId = 2,
            LanguageId = 3,
            Name = "Ամերիկանո",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Latte

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Latte,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Latte,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 7,
            CoffeeCategoryId = 3,
            LanguageId = 1,
            Name = "Latte",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 8,
            CoffeeCategoryId = 3,
            LanguageId = 2,
            Name = "Латте",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 9,
            CoffeeCategoryId = 3,
            LanguageId = 3,
            Name = "Լատե",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Cappuccino

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Cappuccino,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Cappuccino,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 10,
            CoffeeCategoryId = 4,
            LanguageId = 1,
            Name = "Cappuccino",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 11,
            CoffeeCategoryId = 4,
            LanguageId = 2,
            Name = "Капучино",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 12,
            CoffeeCategoryId = 4,
            LanguageId = 3,
            Name = "Կապուչինո",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Mocha

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Mocha,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Mocha,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 13,
            CoffeeCategoryId = 5,
            LanguageId = 1,
            Name = "Mocha",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 14,
            CoffeeCategoryId = 5,
            LanguageId = 2,
            Name = "Моча",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 15,
            CoffeeCategoryId = 5,
            LanguageId = 3,
            Name = "Մոչա",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Macchiato

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Macchiato,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Macchiato,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 16,
            CoffeeCategoryId = 6,
            LanguageId = 1,
            Name = "Macchiato",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 17,
            CoffeeCategoryId = 6,
            LanguageId = 2,
            Name = "Мачиато",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 18,
            CoffeeCategoryId = 6,
            LanguageId = 3,
            Name = "Մաչիատո",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Espresso

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Espresso,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Espresso,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 19,
            CoffeeCategoryId = 7,
            LanguageId = 1,
            Name = "Espresso",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 20,
            CoffeeCategoryId = 7,
            LanguageId = 2,
            Name = "Еспресо",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 21,
            CoffeeCategoryId = 7,
            LanguageId = 3,
            Name = "Եսպրեսօ",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Decaf

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Decaf,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Decaf,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 22,
            CoffeeCategoryId = 8,
            LanguageId = 1,
            Name = "Decaf",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 23,
            CoffeeCategoryId = 8,
            LanguageId = 2,
            Name = "Декаф",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 24,
            CoffeeCategoryId = 8,
            LanguageId = 3,
            Name = "Դեկաֆ",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion

        #region Frappuccino

        modelBuilder.Entity<CoffeeCategory>().HasData(new CoffeeCategory
        {
            Id = (int)CoffeeCategoryEnum.Frappuccino,
            CoffeeCategoryEnum = CoffeeCategoryEnum.Frappuccino,
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 25,
            CoffeeCategoryId = 9,
            LanguageId = 1,
            Name = "Frappuccino",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 26,
            CoffeeCategoryId = 9,
            LanguageId = 2,
            Name = "Фрапучино",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });
        modelBuilder.Entity<CoffeeCategoryTranslation>().HasData(new CoffeeCategoryTranslation
        {
            Id = 27,
            CoffeeCategoryId = 9,
            LanguageId = 3,
            Name = "Ֆրապուփչինո",
            CreatedDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            ModifyDate = new(2023, 1, 1, 0, 0, 0, DateTimeKind.Utc),
            IsDeleted = false,
        });

        #endregion
    }
}
