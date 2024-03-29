﻿using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class CoffeeTypeTranslationConfigurtion : BaseConfiguration<CoffeeTypeTranslation>
{
    public override void Configure(EntityTypeBuilder<CoffeeTypeTranslation> builder)
    {
        base.Configure(builder);

        builder.ToTable("coffee_type_translation");

        builder.Property(x => x.Name)
            .HasMaxLength(256)
            .IsRequired();

        builder.HasIndex(x => new { x.CoffeeTypeId, x.LanguageId });
    }
}
