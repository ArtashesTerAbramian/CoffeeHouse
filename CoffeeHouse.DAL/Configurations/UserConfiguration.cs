using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeHouse.DAL.Configurations;

public class UserConfiguration : BaseConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("users");


        builder.Property(x => x.Email)
            .IsRequired();
        
        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.Property(x => x.UserName)
            .IsRequired();

        builder.HasIndex(x => x.UserName)
            .IsUnique();
    }
}