using CoffeeHouse.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeHouse.DAL.Configurations
{
    public class ErrorConfiguration : BaseConfiguration<Error>
    {
        public override void Configure(EntityTypeBuilder<Error> builder)
        {
            base.Configure(builder);

            builder.ToTable("error");

            builder.Property(x => x.Name)
                .HasMaxLength(256);
        }
    }
}
