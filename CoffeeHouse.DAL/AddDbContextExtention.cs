﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeHouse.DAL;

public static class AddDbContextExtention
{

    public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddDbContext<AppDbContext>(options =>
                                               options.UseNpgsql(configuration.GetConnectionString("CoffeeHouse"), x =>
                                               {
                                                   x.MigrationsHistoryTable("ef_migration_history");
                                               })
                                           .UseSnakeCaseNamingConvention());
    }


}
