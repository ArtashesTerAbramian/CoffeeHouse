using CoffeeHouse.BLL.Enums;
using CoffeeHouse.BLL.Services.LanguageService;
using CoffeeHouse.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeHouse.BLL.Middlewares;

public class LangagueMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var languageService = context.RequestServices.GetRequiredService<ILanguageService>();

        var acceptLanguage = context.Request.Headers["Accept-Language"].ToString();

        languageService.LanguageId = (int)LanguageEnum.English;

        if (!string.IsNullOrWhiteSpace(acceptLanguage))
        {
            if (int.TryParse(acceptLanguage, out var value))
            {
                languageService.LanguageId = value;
            }
        }

        await next(context);
    }
}

public static class LangaugeMiddlewareExtension
{
    public static WebApplication UseLanguageMiddleware(this WebApplication app)
    {
        app.UseMiddleware<LangagueMiddleware>();

        return app;
    }
}