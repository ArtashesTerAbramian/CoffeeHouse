using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Services.ProvinceService;
using CoffeeHouse.DTO.ProvinceDtos;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeHouse.Api.Controllers;

public class ProvinceController : ApiControllerBase
{
    private readonly IProvinceService _provinceService;

    public ProvinceController(IProvinceService provinceService)
    {
        _provinceService = provinceService;
    }

    [HttpGet("get-all")]
    public async Task<PagedResult<List<ProvinceDto>>> GetAll([FromQuery] ProvinceFilter filter)
    {
        return await _provinceService.GetAll(filter);
    }

    [HttpGet("get-by-id")]
    public async Task<Result<ProvinceDto>> Get(long id)
    {
        return await _provinceService.GetById(id);
    }

}
