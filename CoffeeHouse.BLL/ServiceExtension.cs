using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoffeeHouse.BLL.Services.ErrorService;
using CoffeeHouse.BLL.Services.CoffeeCategoryService;
using CoffeeHouse.DAL;
using CoffeeHouse.BLL.Middlewares;
using CoffeeHouse.BLL.Services.ContextModificatorService;
using CoffeeHouse.BLL.Services.LanguageService;
using CoffeeHouse.BLL.Services.CoffeeService;
using CoffeeHouse.BLL.Helpers;
using CoffeeHouse.BLL.Models;

namespace CoffeeHouse.BLL;
public static class ServiceExtension 
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<FileSettings>(options => configuration.GetSection(nameof(FileSettings)).Bind(options));
        services.AddSingleton<IContextModificatorService, WebContextModificatorService>();
        services.AddSingleton<FileHelper>();

        services.AddScoped<LangagueMiddleware>();
        services.AddScoped<ILanguageService, LanguageService>();

        services.AddScoped<IErrorService, ErrorService>();
        services.AddScoped<ICoffeeTypeService, CoffeeTypeService>();
        services.AddScoped<ICoffeeService, CoffeeService>();

        return services;
    }
}
