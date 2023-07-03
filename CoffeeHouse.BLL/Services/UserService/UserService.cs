﻿using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Helpers;
using CoffeeHouse.BLL.Mappers;
using CoffeeHouse.DAL;
using CoffeeHouse.DAL.Models;
using CoffeeHouse.DTO.UsersDtos;
using Microsoft.EntityFrameworkCore;

namespace CoffeeHouse.BLL.Services.UserService;

public class UserService: IUserService
{
    private readonly AppDbContext _db;
    private readonly PasswordHashHelper _passwordHashHelper;

    public UserService(AppDbContext db,
        PasswordHashHelper passwordHashHelper)
    {
        _db = db;
        _passwordHashHelper = passwordHashHelper;
    }
    
    public async Task<Result> AddUserAsync(AddUserDto dto)
    {
        if(_db.Users.Any(x => x.UserName == dto.UserName.ToLower()))
        {
            return Result.Error("User with provided username already exists");
        }
        if (_db.Users.Any(x => x.Email == dto.Email))
        {
            return Result.Error("User with provided Email already exists");
        }
        if (_db.Users.Any(x => x.Phone == dto.Phone))
        {
            return Result.Error("User with provided phone number already exists");
        }

        var user = new User()
        {
            Email = dto.Email,
            UserName = dto.UserName.ToLower(),
            Phone = dto.Phone,
            PasswordHash = _passwordHashHelper.HashPassword(dto.Password)
        };

        await _db.Users.AddAsync(user);

        await _db.SaveChangesAsync();

        return Result.Success();
    }
    
    public async Task<PagedResult<List<UserDto>>> GetAllAsync(UserFilter filter)
    {
        var query = _db.Users;

        var users = await filter.FilterObjects(query).ToListAsync();

        return new PagedResult<List<UserDto>>(await filter.GetPagedInfoAsync(query), users.MapToUsersDtos());
    }

    public async Task<Result<UserDto>> GetByIdAsync(long id)
    {
        var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
        {
            return Result.NotFound();
        }

        return user.MapToUserDto();
    }

    public async Task<Result<UserDto>> GetUserByUsernameAsync(string username)
    {
        var user = await _db.Users.FirstOrDefaultAsync(x => x.UserName == username.ToLower());

        if(user == null)
        {
            return Result.NotFound();
        }

        return user.MapToUserDto();
    }

    public async Task<Result> UpdateAsync(UpdateUserDto dto)
    {
        var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (user == null)
        {
            return Result.NotFound();
        }

        user.Email = dto.Email;
        user.Phone = dto.Phone;
        user.UserName = dto.UserName;

        await _db.SaveChangesAsync();

        return Result.Success();
    }

    public async Task<Result> Delete(long Id)
    {
        var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == Id);

        if(user == null)
        {
            return Result.NotFound();
        }

        user.IsDeleted = true;

        await _db.SaveChangesAsync();

        return Result.Success();
    }
}