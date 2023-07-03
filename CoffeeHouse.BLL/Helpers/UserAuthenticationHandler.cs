using System.Security.Claims;
using System.Text.Encodings.Web;
using CoffeeHouse.BLL.Services.UserService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CoffeeHouse.BLL.Helpers;

public class UserAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly IUserSessionService _userSessionService;

    public UserAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock,
        IUserSessionService userSessionService) : base(options, logger, encoder, clock)
    {
        _userSessionService = userSessionService;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        string token = null;

        token = Request.Headers["Authorization"].ToString();

        if (string.IsNullOrEmpty(token))
        {
            throw new UnauthorizedAccessException("Authorization not provided");
        }

        var user = await _userSessionService.GetByToken(token);

        if (user == null)
        {
            throw new UnauthorizedAccessException("User Not Found");
        }

        var claims = new[] {
            new Claim(ClaimTypes.NameIdentifier, user.UserName),
            new Claim(ClaimTypes.Name, user.Id.ToString()),
        };
        var identity = new ClaimsIdentity(claims, Scheme.Name);
        var principal = new ClaimsPrincipal(identity);
        var ticket = new AuthenticationTicket(principal, Scheme.Name);

        return AuthenticateResult.Success(ticket);
    }
}