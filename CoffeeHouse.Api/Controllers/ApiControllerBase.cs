using Microsoft.AspNetCore.Mvc;

namespace CoffeeHouse.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public abstract class ApiControllerBase : ControllerBase
{
    public ApiControllerBase()
    {

    }
}
