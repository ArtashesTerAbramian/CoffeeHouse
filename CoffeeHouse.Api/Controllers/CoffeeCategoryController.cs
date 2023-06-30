using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.BLL.Services.CoffeeCategoryService;
using CoffeeHouse.Dto;
using CoffeeHouse.DTO.CoffeeTypeDtos;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeHouse.Api.Controllers
{
    public class CoffeeCategoryController : ApiControllerBase
    {
        private readonly ICoffeeCategoryService _coffeeCategoryService;

        public CoffeeCategoryController(ICoffeeCategoryService coffeeCategoryService)
        {
            _coffeeCategoryService = coffeeCategoryService;
        }

        [HttpGet("get-all")]
        public async Task<PagedResult<List<CoffeeTypeDto>>> GetAll([FromQuery] CoffeeCategoryFilter filter)
        {
            return await _coffeeCategoryService.GetAll(filter);
        }

        [HttpGet("get-by-id")]
        public async Task<Result<CoffeeTypeDto>> Get(long id)
        {
            return await _coffeeCategoryService.GetById(id);
        }

        [HttpPost("add")]
        [DisableRequestSizeLimit]
        public async Task<Result> Add(AddCoffeeTypeDto dto)
        {
            return await _coffeeCategoryService.Add(dto);
        }

        [HttpPost("update")]
        [DisableRequestSizeLimit]
        public async Task<Result> Update(UpdateCoffeeTypeDto dto)
        {
            return await _coffeeCategoryService.Update(dto);
        }

        [HttpPost("delete")]
        public async Task<Result> Delete(BaseDto dto)
        {
            return await _coffeeCategoryService.Delete(dto.Id);
        }
    }
}
