using CoffeeHouse.DTO;

namespace CoffeeHouse.BLL.Services.ErrorService;
public interface IErrorService
{
    Task<ErrorModelDto> GetById(long id);
}