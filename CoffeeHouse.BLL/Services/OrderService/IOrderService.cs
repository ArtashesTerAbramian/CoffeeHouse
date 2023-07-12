using Ardalis.Result;
using CoffeeHouse.BLL.Filters;
using CoffeeHouse.DTO.OrderDtos;

namespace CoffeeHouse.BLL.Services.OrderService;

public interface IOrderService
{
    Task<Result> AddOrderAsync(AddOrderDto dto);
    Task<Result> Delete(long id);
    Task<PagedResult<List<OrderDto>>> GetAllAsync(OrderFilter filter);
    Task<Result<OrderDto>> GetByIdAsync(long id);
    Task<Result> UpdateAsync(UpdateOrderDto dto);
}
