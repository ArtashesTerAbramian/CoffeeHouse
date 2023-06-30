using CoffeeHouse.DAL;

namespace CoffeeHouse.BLL.Services.ContextModificatorService;
public class WebContextModificatorService : IContextModificatorService
{
    public bool IsGlobalQueryFiltersEnable => true;
}