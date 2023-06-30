using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CoffeeHouse.BLL.Services.ErrorService;
using CoffeeHouse.BLL.Services.CoffeeCategoryService;
using CoffeeHouse.DAL;
using CoffeeHouse.BLL.Middlewares;
using CoffeeHouse.BLL.Services.ContextModificatorService;
using CoffeeHouse.BLL.Services.LanguageService;

namespace CoffeeHouse.BLL;
public static class ServiceExtension 
{
    public static IServiceCollection AddWebServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IContextModificatorService, WebContextModificatorService>();

        services.AddScoped<LangagueMiddleware>();
        services.AddScoped<ILanguageService, LanguageService>();

        services.AddScoped<IErrorService, ErrorService>();
        services.AddScoped<ICoffeeCategoryService, CoffeeCategoryService>();

        return services;
    }
}
