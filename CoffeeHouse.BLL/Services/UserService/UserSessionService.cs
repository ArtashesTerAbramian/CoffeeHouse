﻿using Ardalis.Result;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.BLL.Models;
using CoffeeHouse.DAL;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO;
using CoffeeHouse.DTO.UsersDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace CoffeeHouse.BLL.Services.UserService;

public class UserSessionService : IUserSessionService
{
    private readonly AppDbContext _db;
    private readonly IHttpContextAccessor _httpContext;
    private readonly AuthOptions _options;

    public UserSessionService(AppDbContext db,
        IOptions<AuthOptions> options,
        IHttpContextAccessor httpContext)
    {
        _db = db;
        _httpContext = httpContext;
        _options = options.Value;
    }
    
    public async Task<Result<UserSessionDto>> Add(LoginDto dto)
    {
        var user = await _db.Users
            .FirstOrDefaultAsync(x => x.UserName == dto.UserName.ToLower());

        
        // if (dbAdmin == null || !Crypto.VerifyHashedPassword(dbAdmin.PasswordHash, dto.Password))
        // {
        //     return await _errorHelper.SetError(response, ErrorConstants.IncorrectEnteredData);
        // }
        
        if (user == null)
        {
            return Result.NotFound("Incorrect enteres data");
        }
        
        var token = Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");
        
        var session = new UserSession()
        {
            UserId = user.Id,
            Token = token,
            Id = user.Id
        };

        _db.UserSessions.Add(session);

        await _db.SaveChangesAsync();

        var response = session.MapToUserSessionDto();

        return response;
    }

    public async Task<Result<bool>> Delete()
    {
        _httpContext.HttpContext.Request.Headers.TryGetValue(HeaderNames.Authorization, out var token);

        var session = await _db.UserSessions.FirstOrDefaultAsync(x => x.Token == token.ToString());

        if (session != null)
        {
            session.IsExpired = true;
            session.IsDeleted = true;

            await _db.SaveChangesAsync();
        }

        return true;
    }

    public async Task<User> GetByToken(string token)
    {
        var userSession = await _db.UserSessions
            .Include(x => x.User)
            .FirstOrDefaultAsync(x => x.Token == token && !x.IsExpired
                                                       && x.User.IsDeleted != true);

        if (userSession == null)
        {
            return null;
        }
        
        if (userSession.ModifyDate.Value.AddMinutes(_options.TokenExpirationTimeInMinutes) < DateTime.Now)
        {
            userSession.IsExpired = true;

            await _db.SaveChangesAsync();

            return null;
        }
        
        userSession.ModifyDate = DateTime.Now;

        await _db.SaveChangesAsync();

        return userSession.User;
    }

    public Result<UserDto> GetUserCurrentInfo()
    {
        throw new NotImplementedException();
    }
}